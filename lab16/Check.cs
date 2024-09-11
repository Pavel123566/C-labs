using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab16
{
    internal class Check
    {
        public static double CheckDouble()
        {
            var input = Console.ReadLine();

            if (double.TryParse(input, out var output))
                return output;

            Console.WriteLine("Error type!");
            return CheckDouble();
        }
    }
}
