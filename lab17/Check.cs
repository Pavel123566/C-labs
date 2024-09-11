using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab17
{
    internal static class Check
    {
        public static string ReadString()
        {
            string input = Console.ReadLine();
            if(input.Replace(" ", "").Length < 1 || !input.All(char.IsLetterOrDigit))
            {
                Console.WriteLine("Try again...");
                return ReadString();
            }
            return input;
        }
        public static double ReadDouble()
        {
            if (!double.TryParse(Console.ReadLine(), out double input) || input < 0)
            {
                Console.WriteLine("Try again...");
                return ReadDouble();
            }
            return input;
        }
        public static byte ReadByte()
        {
            if (!byte.TryParse(Console.ReadLine(), out byte input) || input < 0)
            {
                Console.WriteLine("Try again...");
                return ReadByte();
            }
            return input; 
        }
    }
}
