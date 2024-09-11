using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var is_enabled = true;
            int choice;
            while(is_enabled)
            {
                Console.WriteLine("1 - task1");
                Console.WriteLine("2 - task2");
                Console.WriteLine("3 - task3");
                Console.WriteLine("4 - exit");
                Console.WriteLine("Input: ");
                choice = Check.ReadInt();
                string str;
                switch(choice)
                {
                    case 1:
                        Console.WriteLine("Input string:");
                        str = Check.ReadString();
                        Console.WriteLine("Input substring");
                        string substr = Check.ReadString(str.Length);
                        Console.WriteLine($"Result: {StringWork.task1(str, substr)}");
                        break;
                    case 2:
                        Console.WriteLine("Input string");
                        str = Check.ReadUpper();
                        Console.WriteLine($"Result: {StringWork.task2(str)}");
                        break;
                    case 3:
                        Console.WriteLine("Input string");
                        str = Check.ReadString();
                        Console.WriteLine($"Result: {StringWork.task3(str)}");
                        break;
                    case 4:
                        is_enabled = false;
                        break;
                }
            }
        }
    }
}
