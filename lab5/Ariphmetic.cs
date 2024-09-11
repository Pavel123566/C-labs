using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Ariphmetic
    {
        public static int factorial(int num)
        {
            if (num == 1) return 1;
            return num * factorial(num - 1);
        }
        public static double average(int[] nums)
        {
            double sum = 0;
            foreach (int num in nums)
            {
                sum += num;
            }
            return sum / nums.Length;
        }
        public static double[] square(int a, int b, int c)
        {
            // return NULL if no roots
            double discrim = Math.Pow(b, 2) - 4 * a * c;
            double[] roots = new double[1];
            if (discrim < 0)
            {
                return null;
            }
            else if (discrim == 0)
            {
                roots[0] = (-b / (2 * a));
            }
            else
            {
                Array.Resize(ref roots, 2);
                roots[0] = (-b - Math.Sqrt(discrim)) / (2 * a);
                roots[1] = (-b + Math.Sqrt(discrim)) / (2 * a);
            }
            return roots;
        }
    }
}
