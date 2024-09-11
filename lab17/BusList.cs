using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab17
{
    internal class BusList
    {
        private List<Bus> Buses;
        public BusList()
        {
            Buses = new List<Bus>();
        }
        public void AddBus()
        {
            Bus bus = new Bus();
            bus.Input();
            Buses.Add(bus);
        }
        public void Print()
        {
            foreach (var bus in Buses)
            {
                bus.Print();
            }
        }
        public void Menu()
        {
            if (Buses.Count == 0)
            {
                Console.WriteLine("create first bus");
                AddBus();
            }
            ConsoleKey key = ConsoleKey.NoName;
            var iter = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("← - Left");
                Console.WriteLine("→ - Right");
                Console.WriteLine(@"↓ - Delete");
                Console.WriteLine(@"↑ - Replace");
                Console.WriteLine("N - Create new element");
                Console.WriteLine("S - Sort");
                Console.WriteLine();
                Buses[iter].Print();

                key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.LeftArrow:
                        if (iter > 0)
                            iter--;
                        break;
                    case ConsoleKey.RightArrow:
                        if (iter < Buses.Count - 1)
                            iter++;
                        break;
                    case ConsoleKey.DownArrow:
                        Buses.RemoveAt(iter);
                        iter--;
                        break;
                    case ConsoleKey.UpArrow:
                        Buses[iter].Input();
                        break;
                    case ConsoleKey.N:
                        AddBus();
                        break;
                    case ConsoleKey.S:
                        Buses.Sort((x, y) => x.Power.CompareTo(y.Power));
                        break;
                }
            } while (key != ConsoleKey.Escape);
        }
    }
}
