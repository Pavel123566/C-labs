using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bus = new Bus { Model = "Mercedes", Power = 200, Seats = 50 };
            var bus2 = (Bus)bus.Clone();
            bus2.Model = "BMW";
            bus2.Power = 300;
            bus2.Seats = 40;
            bus.Print();
            bus2.Print();
            Console.ReadKey();
        }
    }
}
