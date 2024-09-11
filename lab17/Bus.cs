using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab17
{
    internal class Bus
    {
        public string Model { get; set; }
        public double Power { get; set; }
        public byte Seats { get; set; }
        
        public void Input()
        {
            Console.WriteLine("Enter model: ");
            Model = Check.ReadString();
            Console.WriteLine("Enter power: ");
            Power = Check.ReadDouble();
            Console.WriteLine("Enter seats: ");
            Seats = Check.ReadByte();
        }
        public void Print()
        {
            Console.WriteLine($"Model: {Model}, Power: {Power}, Seats: {Seats}");
        }
        
    }
}
