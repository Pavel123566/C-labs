using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Write("Enter X: ");
                double x = Check.CheckDouble();
                Console.Write("Enter Y: ");
                double y = Check.CheckDouble();
                if (lab16dll.CheckCords.check(x, y))
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }
        }
    }
}
