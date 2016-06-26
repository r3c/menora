using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using Menora.Temperature;
using Newtonsoft.Json.Linq;

namespace Menora
{
    class Config
    {
        public TimeSpan Interval
        {
            get; set;
        }

        public Point[] Points
        {
            get; set;
        }

        public Dictionary<string, Rule> Rules
        {
            get; set;
        }

        public bool Tray
        {
            get; set;
        }

        public Config()
        {
            this.Interval = TimeSpan.FromSeconds(60);
            this.Points = new []
            {
                new Point(4 * 60, 3500),
                new Point(8 * 60, 6500),
                new Point(18 * 60, 6500),
                new Point(22 * 60, 3500)
            };
            this.Rules = new Dictionary<string, Rule>();
            this.Tray = true;
        }

        public static bool TryParse(string json, out Config config, out string message)
        {
            JObject level0;
            JObject level1object;
            List<Point> points;
            Rule rule;
            Dictionary<string, Rule> rules;
            JToken token;
            
            try
            {
                level0 = JObject.Parse(json);
            }
            catch (Exception exception)
            {
                config = null;
                message = exception.Message;

                return false;
            }

            config = new Config();

            if (level0.TryGetValue("interval", out token))
                config.Interval = TimeSpan.FromSeconds(token.Value<int>());

            if (level0.TryGetValue("points", out token) || level0.TryGetValue("times", out token))
            {
                level1object = token as JObject;
                points = new List<Point>();

                if (level1object != null)
                {
                    foreach (var pair in level1object)
                    {
                        var match = Regex.Match(pair.Key, "^([0-9]{1,2}):([0-9]{1,2})$");

                        if (match.Success)
                        {
                            var time = int.Parse(match.Groups[1].Value, CultureInfo.InvariantCulture) * 60 + int.Parse(match.Groups[2].Value, CultureInfo.InvariantCulture);

                            points.Add(new Point(time, pair.Value.Value<int>()));
                        }
                    }
                }

                config.Points = points.OrderBy(o => o.MinutesFromDayStart).ToArray();
            }

            if (level0.TryGetValue("rules", out token) || level0.TryGetValue("behaviors", out token))
            {
                level1object = token as JObject;
                rules = new Dictionary<string, Rule>();

                if (level1object != null)
                {
                    foreach (var pair in level1object)
                    {
                        if (Enum.TryParse<Rule>(pair.Value.Value<string>(), true, out rule))
                            rules[pair.Key] = rule;
                    }
                }

                config.Rules = rules;
            }

            if (level0.TryGetValue("tray", out token))
                config.Tray = token.Value<bool>();

            message = null;

            return true;
        }

        public string ToJSON()
        {
            var json = new JObject();
            var points = new JObject();
            var rules = new JObject();

            foreach (var point in this.Points)
                points[string.Format(CultureInfo.InvariantCulture, "{0:00}:{1:00}", point.MinutesFromDayStart / 60, point.MinutesFromDayStart % 60)] = point.TempKelvin;

            foreach (var rule in this.Rules)
                rules[rule.Key] = rule.Value.ToString();

            json["interval"] = (int)this.Interval.TotalSeconds;
            json["points"] = points;
            json["rules"] = rules;
            json["tray"] = this.Tray;

            return json.ToString();
        }
    }
}
