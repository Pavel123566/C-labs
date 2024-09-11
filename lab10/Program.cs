using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace lab10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var devices = new List<Device>();
            int choice = 0;
            int choice2 = 0;
            do
            {
                Console.WriteLine("1. Add device");
                Console.WriteLine("2. Print devices");
                Console.WriteLine("3. exit");
                choice = Check.ReadInt(1, 3);
                switch(choice)
                {
                    case 1:
                        Console.WriteLine("1. Phone");
                        Console.WriteLine("2. Pda");
                        Console.WriteLine("3. Exit");
                        choice2 = Check.ReadInt(1, 3);
                        switch (choice2)
                        {
                            case 1:
                                devices.Add(new Phone());
                                devices[devices.Count - 1].Input();
                                break;
                            case 2:
                                devices.Add(new Pda());
                                devices[devices.Count - 1].Input();
                                break;
                            case 3:
                                break;
                        }
                        break;
                    case 2:
                        Console.WriteLine("1. Print all");
                        Console.WriteLine("2. Print only phones");
                        Console.WriteLine("3. Print only pdas");
                        choice2 = Check.ReadInt(1, 3);
                        switch (choice2)
                        {
                            case 1:
                                foreach (var device in devices)
                                {
                                    device.Print();
                                }
                                break;
                            case 2:
                                foreach (var device in devices)
                                {
                                    if (device is Phone)
                                    {
                                        device.Print();
                                    }
                                }
                                break;
                            case 3:
                                foreach (var device in devices)
                                {
                                    if (device is Pda)
                                    {
                                        device.Print();
                                    }
                                }
                                break;
                        }
                        break;
                }
            }
            while (choice != 3);
        }
    }
}
