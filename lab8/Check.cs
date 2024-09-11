using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    internal class Check
    {
        public static int CheckNumber()
        {
            var input = Console.ReadLine();

            if (int.TryParse(input, out var output))
                return output;

            Console.WriteLine("Error type!");
            return CheckNumber();
        }
    }
}
