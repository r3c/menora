using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace Menora
{
    class TempConfig
    {
        public const int DefaultTemperature = 6500;
        private const int MinutesPerDay = 24 * 60;

        public TempEntry[] Entries
        {
            get
            {
                return this.entries;
            }
        }

        public int Interval
        {
            get
            {
                return this.interval;
            }
        }

        public bool Tray
        {
            get
            {
                return this.tray;
            }
        }

        private readonly TempEntry[] entries;
        private readonly HashSet<string> excludes;
        private readonly int interval;
        private readonly bool tray;

        public TempConfig(IEnumerable<TempEntry> entries, IEnumerable<string> excludes, int interval, bool tray)
        {
            this.entries = entries.OrderBy(o => o.MinutesFromDayStart).ToArray();
            this.excludes = new HashSet<string>(excludes);
            this.interval = interval;
            this.tray = tray;
        }

        public static bool TryParse(string json, out TempConfig config)
        {
            List<TempEntry> entries;
            List<string> excludes;
            int interval;
            JsonObject level0;
            JsonArray level1Array;
            JsonObject level1Object;
            object obj;
            bool tray;

            if (!SimpleJson.TryDeserializeObject(json, out obj))
            {
                config = null;

                return false;
            }

            entries = new List<TempEntry>();
            excludes = new List<string>();
            interval = 60;
            level0 = obj as JsonObject;
            tray = true;

            if (level0 != null)
            {
                if (level0.TryGetValue("excludes", out obj))
                {
                    level1Array = obj as JsonArray;
    
                    if (level1Array != null)
                    {
                        foreach (var value in level1Array)
                            excludes.Add(Convert.ToString(value, CultureInfo.InvariantCulture));
                    }
                }

                if (level0.TryGetValue("interval", out obj) && obj is IConvertible)
                    interval = Convert.ToInt32(obj);
    
                if (level0.TryGetValue("times", out obj))
                {
                    level1Object = obj as JsonObject;
    
                    if (level1Object != null)
                    {
                        foreach (var pair in level1Object)
                        {
                            var match = Regex.Match(pair.Key, "^([0-9]{1,2}):([0-9]{1,2})$");
    
                            if (!match.Success)
                            {
                                config = null;
    
                                return false;
                            }
    
                            var temp = Convert.ToInt32(pair.Value, CultureInfo.InvariantCulture);
                            var time = int.Parse(match.Groups[1].Value, CultureInfo.InvariantCulture) * 60 + int.Parse(match.Groups[2].Value, CultureInfo.InvariantCulture);
    
                            entries.Add(new TempEntry(time, temp));
                        }
                    }
                }

                if (level0.TryGetValue("tray", out obj) && obj is IConvertible)
                    tray = Convert.ToBoolean(obj);
            }

            config = new TempConfig(entries, excludes, interval, tray);

            return true;
        }

        public bool IsEnabled(IEnumerable<string> processes)
        {
            // Do not fetch process list if there is nothing to exclude
            if (this.excludes.Count == 0)
                return true;

            // Search for excluded processes in currently running ones
            return !processes.Any(this.excludes.Contains);
        }

        public int TemperatureAt(int minutesFromDayStart)
        {
            if (this.entries.Length < 1)
                return TempConfig.DefaultTemperature;

            // Find index of entry following specified minutes from day start
            int index = 0;

            while (index < this.entries.Length && minutesFromDayStart > entries[index].MinutesFromDayStart)
                ++index;

            // Get begin and end entries surrounding specified minutes from day start 
            TempEntry entryBegin = this.entries[(index + this.entries.Length - 1) % this.entries.Length];
            TempEntry entryEnd = this.entries[index % this.entries.Length];

            // Compute ratio of elapsed time on total time between begin and end entries
            int elapsed = (minutesFromDayStart - entryBegin.MinutesFromDayStart + TempConfig.MinutesPerDay) % TempConfig.MinutesPerDay;
            int total = (entryEnd.MinutesFromDayStart - entryBegin.MinutesFromDayStart + TempConfig.MinutesPerDay) % TempConfig.MinutesPerDay;

            double alpha = (double)elapsed / total;

            // Interpolate temperature according to elapsed time
            return (int)Math.Round((1 - alpha) * entryBegin.TempKelvin + alpha * entryEnd.TempKelvin);
        }
    }
}
