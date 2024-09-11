using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    internal class Pda : Device
    {
        public int Memory { get; set; }
        public string Os { get; set; }
        public TouchScreenType TouchScreen { get; set; }
        public override void Input()
        {
            base.Input();
            Console.WriteLine("Input Memory: ");
            Memory = Check.ReadInt(1, 1000);
            Console.WriteLine("Input Os: ");
            Os = Check.ReadName();
            Console.WriteLine("Input TouchScreen \n" +
                "(1-Common, 2-Resistive, 3-Capacitive): ");
            TouchScreen = (TouchScreenType)Check.ReadInt(1, 3);
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Memory: " + Memory);
            Console.WriteLine("Os: " + Os);
            Console.WriteLine("TouchScreen: " + TouchScreen);
        }
    }
}
