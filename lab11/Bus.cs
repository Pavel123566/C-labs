using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    internal class Bus : IPrintable, ICloneable
    {
        public string Model { get; set; }
        public double Power { get; set; }
        public byte Seats { get; set; }
        public void Print()
        {
            Console.WriteLine($"Model: {Model}, Power: {Power}, Seats: {Seats}");
        }
        public object Clone()
        {
            return new Bus { Model = this.Model, Power = this.Power, Seats = this.Seats };
        }
    }
}
