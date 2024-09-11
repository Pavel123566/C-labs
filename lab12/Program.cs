using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace lab12
{
    internal class Program
    {
        static void Main(string[] args)
        {
			while (true)
            {
                string input = Console.ReadLine();
                if (Double.TryParse(input, out double result))
                {
                    Console.WriteLine($"z1 = {MathFuncs.z1(result)}");
                    Console.WriteLine($"z2 = {MathFuncs.z2(result)}");
                }
                else
                {
                    Console.WriteLine("Неверный ввод");
                }
            }
        }
    }
}
