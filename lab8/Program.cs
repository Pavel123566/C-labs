using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace lab8
{
    internal class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("--MAIN MENU--");
                Console.WriteLine("1. Task");
                Console.WriteLine("2. Exit");
                int choice = Check.CheckNumber();
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter text: ");
                        string text = Console.ReadLine();
                        Regexx.PrintInColors(text);
                        break;
                    case 2:
                        return;
                }
            }
        }
    }
}
