using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    internal class Device
    {
        public string Fabricator { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Standarts { get; set; }

        public virtual void Input()
        {
            Console.WriteLine("Input fabricator: ");
            Fabricator = Check.ReadName();
            Console.WriteLine("Input Model: ");
            Model = Check.ReadStringWithNumbers();
            Console.WriteLine("Input Year: ");
            Year = Check.ReadYear();
            Console.WriteLine("Input Standarts (separated by space): \n" +
                "(2g, 3g, 4g, 5g)");
            string[] arr = { "2g", "3g", "4g", "5g" };
            Standarts = Check.ReadListOfStrings(arr);
        }
        public virtual void Print()
        {
            Console.WriteLine("Fabricator: " + Fabricator);
            Console.WriteLine("Model: " + Model);
            Console.WriteLine("Year: " + Year);
            Console.WriteLine("Standarts: " + Standarts);
        }
    }
}
