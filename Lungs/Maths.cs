using System;

namespace Lungs
{
    class Maths
    {
        public static int Round(double x)
        {
            return (int)Math.Round(x);
        }

        public static double Sqr(double x)
        {
            return x * x;
        }

        public static double Sqrt(double x)
        {
            return Math.Sqrt(x);
        }

        public static int Min(int a, int b, int c)
        {
            return Math.Min(a, Math.Min(b, c));
        }

        public static int Max(int a, int b, int c)
        {
            return Math.Max(a, Math.Max(b, c));
        }
    }
}