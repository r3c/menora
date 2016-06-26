using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace Menora.Temperature
{
    static class Gamma
    {
        [DllImport("user32.dll")]
        public static extern IntPtr GetDC(IntPtr hWnd);
        [DllImport("user32.dll")]
        public static extern void ReleaseDC(IntPtr hDC, IntPtr hWnd);
        [DllImport("gdi32.dll")]
        public static extern int GetDeviceGammaRamp(IntPtr hDC, ref Ramp lpRamp);
        [DllImport("gdi32.dll")]
        public static extern bool SetDeviceGammaRamp(IntPtr hDC, ref Ramp lpRamp);

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct Ramp
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public UInt16[] Red;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public UInt16[] Green;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public UInt16[] Blue;
        }

        // Thanks to http://www.tannerhelland.com/4435/convert-temperature-rgb-algorithm-code/
        private static void ComputeRamp(int tmpKelvin, out int rMultiplier, out int gMultiplier, out int bMultiplier)
        {
            double tmpCalc;
            tmpKelvin = Math.Min(40000, Math.Max(1000, tmpKelvin + 100));
            tmpKelvin = (int)Math.Round(tmpKelvin / 100.0d, 0);
            
            // Red
            if (tmpKelvin < 66)
            {
                rMultiplier = 255;
            }
            else
            {
                tmpCalc = tmpKelvin - 60;
                tmpCalc = 329.698727446 * Math.Pow(tmpCalc, -0.1332047592);
                rMultiplier = (int) Math.Max(0, Math.Min(255, tmpCalc));
            }

            // Green
            if (tmpKelvin <= 66)
            {
                tmpCalc = tmpKelvin;
                tmpCalc = 99.4708025861 * Math.Log(tmpCalc) - 161.1195681661;
                gMultiplier = (int)Math.Max(0, Math.Min(255, tmpCalc));
            }
            else
            {
                tmpCalc = tmpKelvin - 60;
                tmpCalc = 288.1221695283 * Math.Pow(tmpCalc, -0.0755148492);
                gMultiplier = (int)Math.Max(0, Math.Min(255, tmpCalc));
            }

            // Blue
            if (tmpKelvin >= 66)
            {
                bMultiplier = 255;
            }
            else if (tmpKelvin <= 19)
            {
                bMultiplier = 0;
            }
            else
            {
                tmpCalc = tmpKelvin - 10;
                tmpCalc = 138.5177312231 * Math.Log(tmpCalc) - 305.0447927307;
                bMultiplier = (int)Math.Max(0, Math.Min(255, tmpCalc));
            }
        }

        public static void ApplyGamma(int tmpKelvin)
        {
            IntPtr hdc = Gamma.GetDC(IntPtr.Zero);

            try
            {
                Ramp ramp = new Ramp();
                int rMultiplier, gMultiplier, bMultiplier;
                Gamma.ComputeRamp(tmpKelvin, out rMultiplier, out gMultiplier, out bMultiplier);
                // Fill the RGB values
                ramp.Red = new ushort[256];
                ramp.Green = new ushort[256];
                ramp.Blue = new ushort[256];
                for (int i = 0; i < 256; i++)
                {
                    ramp.Red[i] = (ushort)(i * 256 * rMultiplier / 255);
                    ramp.Green[i] = (ushort)(i * 256 * gMultiplier / 255);
                    ramp.Blue[i] = (ushort)(i * 256 * bMultiplier / 255);
                }
                Gamma.SetDeviceGammaRamp(hdc, ref ramp);
            }
            finally
            {
                Gamma.ReleaseDC(hdc, IntPtr.Zero);
            }
        }
    }
}
