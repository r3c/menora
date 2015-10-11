using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Linq;

namespace Menora
{
    class Config
    {
        public const int DefaultTemperature = 6500;
        private const int MinutesPerDay = 24 * 60;

        public int Interval
        {
            get
            {
                return this.interval;
            }
        }

        public TimeTemperature[] Times
        {
            get
            {
                return this.times;
            }
        }

        public bool Tray
        {
            get
            {
                return this.tray;
            }
        }

        private readonly Dictionary<string, Behavior> behaviors;
        private readonly int interval;
        private readonly TimeTemperature[] times;
        private readonly bool tray;

        public Config(IEnumerable<TimeTemperature> times, IDictionary<string, Behavior> behaviors, int interval, bool tray)
        {
            this.behaviors = new Dictionary<string, Behavior>(behaviors);
            this.interval = interval;
            this.times = times.OrderBy(o => o.MinutesFromDayStart).ToArray();
            this.tray = tray;
        }

        public static bool TryParse(string json, out Config config)
        {
            Behavior behavior;
            Dictionary<string, Behavior> behaviors;
            int interval;
            JObject level0;
            JObject level1object;
            List<TimeTemperature> times;
            JToken token;
            bool tray;

            try
            {
                level0 = JObject.Parse(json);
            }
            catch
            {
                config = null;

                return false;
            }

            behaviors = new Dictionary<string, Behavior>();
            interval = 60;
            times = new List<TimeTemperature>();
            tray = true;

            if (level0.TryGetValue("behaviors", out token))
            {
                level1object = token as JObject;

                if (level1object != null)
                {
                    foreach (var pair in level1object)
                    {
                        if (!Enum.TryParse<Behavior>(pair.Value.Value<string>(), true, out behavior))
                        {
                            config = null;

                            return false;
                        }

                        behaviors[pair.Key] = behavior;
                    }
                }
            }

            if (level0.TryGetValue("interval", out token))
                interval = token.Value<int>();

            if (level0.TryGetValue("times", out token))
            {
                level1object = token as JObject;

                if (level1object != null)
                {
                    foreach (var pair in level1object)
                    {
                        var match = Regex.Match(pair.Key, "^([0-9]{1,2}):([0-9]{1,2})$");

                        if (!match.Success)
                        {
                            config = null;

                            return false;
                        }

                        var time = int.Parse(match.Groups[1].Value, CultureInfo.InvariantCulture) * 60 + int.Parse(match.Groups[2].Value, CultureInfo.InvariantCulture);

                        times.Add(new TimeTemperature(time, pair.Value.Value<int>()));
                    }
                }
            }

            if (level0.TryGetValue("tray", out token))
                tray = token.Value<bool>();

            config = new Config(times, behaviors, interval, tray);

            return true;
        }

        public Behavior GetPolicy(IEnumerable<string> processes)
        {
            Behavior candidate;
            Behavior result;

            // Do not fetch process list if there is nothing to exclude
            if (this.behaviors.Count == 0)
                return Behavior.Apply;

            // Search for behavior matching of currently running processes
            result = Behavior.Apply;

            foreach (var process in processes)
            {
                if (this.behaviors.TryGetValue(process, out candidate) && candidate > result)
                    result = candidate;
            }

            return result;
        }

        public int TemperatureAt(int minutesFromDayStart)
        {
            if (this.times.Length < 1)
                return Config.DefaultTemperature;

            // Find index of entry following specified minutes from day start
            int index = 0;

            while (index < this.times.Length && minutesFromDayStart > times[index].MinutesFromDayStart)
                ++index;

            // Get begin and end entries surrounding specified minutes from day start 
            TimeTemperature begin = this.times[(index + this.times.Length - 1) % this.times.Length];
            TimeTemperature end = this.times[index % this.times.Length];

            // Compute ratio of elapsed time on total time between begin and end entries
            int elapsed = (minutesFromDayStart - begin.MinutesFromDayStart + Config.MinutesPerDay) % Config.MinutesPerDay;
            int total = (end.MinutesFromDayStart - begin.MinutesFromDayStart + Config.MinutesPerDay) % Config.MinutesPerDay;

            double alpha = (double)elapsed / total;

            // Interpolate temperature according to elapsed time
            return (int)Math.Round((1 - alpha) * begin.TempKelvin + alpha * end.TempKelvin);
        }
    }
}
