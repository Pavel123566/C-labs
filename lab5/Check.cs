using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    internal static class Check
    {
        public static int ReadInt()
        {
            string input = Console.ReadLine();
            if (!int.TryParse(input, out int result))
            {
                Console.WriteLine("Try again...");
                return ReadInt();
            }
            return result;
        }
        public static int ReadInt(int more, int less)
        {
            string input = Console.ReadLine();
            if (!int.TryParse(input, out int result) || result > less || result < more)
            {
                Console.WriteLine("Try again...");
                return ReadInt(more, less);
            }
            return result;
        }
        public static string ReadName()
        {
            string input = Console.ReadLine();
            if (!input.All(char.IsLetter))
            {
                Console.WriteLine("Try again...");
                return ReadName();
            }
            return input;
        }
        public static char ReadSex()
        {
            string input = Console.ReadLine();
            input.ToUpper();
            if (input.Length != 1 || (input[0] != 'M' && input[0] != 'F' ))
            {
                Console.WriteLine("Try again...");
                return ReadSex();
            }
            return input[0];
        }
    }
}

