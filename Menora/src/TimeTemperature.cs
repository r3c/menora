using System;

namespace Menora
{
    public struct TimeTemperature
    {
        public int MinutesFromDayStart;
        public int TempKelvin;

        public TimeTemperature(int minutesFromDayStart, int tempKelvin)
        {
            this.MinutesFromDayStart = minutesFromDayStart;
            this.TempKelvin = tempKelvin;
        }
    }
}
