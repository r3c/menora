using System;

namespace Menora
{
    public struct TempEntry
    {
        public int MinutesFromDayStart;
        public int TempKelvin;

        public TempEntry(int minutesFromDayStart, int tempKelvin)
        {
            this.MinutesFromDayStart = minutesFromDayStart;
            this.TempKelvin = tempKelvin;
        }
    }
}
