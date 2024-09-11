using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace lab12
{
    internal class MathFuncs
    {
        public static double z1(double x)
        {
            try
            {
                var doubleXSqrt = Math.Sqrt(2 * x);

                double y = (2 / (x - doubleXSqrt) + (x + 2) / doubleXSqrt - x / (doubleXSqrt + 2)) * ((Math.Sqrt(x) - Math.Sqrt(2)) / (x + 2));
                if (y is double.NaN)
                {
                    throw new Exception("Не вещественное число");
                }
                return y;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Возникло исключение: {ex}");
                return double.NaN;
            }
        }
        public static double z2(double x)
        {
            try
            {
                double y = 1 / (Math.Sqrt(x) + Math.Sqrt(2));
                if (y == double.NaN)
                {
                    throw new Exception("Не вещественное число");
                }
                return y;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Возникло исключение: {ex}");
                return double.NaN;
            }
        }
    }
}
