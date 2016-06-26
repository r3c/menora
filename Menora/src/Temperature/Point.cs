using System;
using System.Collections.Generic;

namespace Menora.Temperature
{
    public struct Point
    {
        public const int DefaultTemperature = 6500;
        private const int MinutesPerDay = 24 * 60;

        public int MinutesFromDayStart;
        public int TempKelvin;

        public Point(int minutesFromDayStart, int tempKelvin)
        {
            this.MinutesFromDayStart = minutesFromDayStart;
            this.TempKelvin = tempKelvin;
        }

        public static int TemperatureAt(IList<Point> points, int minutesFromDayStart)
        {
            if (points.Count < 1)
                return Point.DefaultTemperature;

            // Find index of entry following specified minutes from day start
            int index = 0;

            while (index < points.Count && minutesFromDayStart > points[index].MinutesFromDayStart)
                ++index;

            // Get begin and end entries surrounding specified minutes from day start 
            Point begin = points[(index + points.Count - 1) % points.Count];
            Point end = points[index % points.Count];

            // Compute ratio of elapsed time on total time between begin and end entries
            int elapsed = (minutesFromDayStart - begin.MinutesFromDayStart + Point.MinutesPerDay) % Point.MinutesPerDay;
            int total = (end.MinutesFromDayStart - begin.MinutesFromDayStart + Point.MinutesPerDay) % Point.MinutesPerDay;

            double alpha = (double)elapsed / total;

            // Interpolate temperature according to elapsed time
            return (int)Math.Round((1 - alpha) * begin.TempKelvin + alpha * end.TempKelvin);
        }
    }
}
