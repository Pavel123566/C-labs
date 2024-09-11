using System;

namespace lab6
{
    static internal class Check
    {
        public static double ReadDouble()
        {
            string input = Console.ReadLine();
            if (!double.TryParse(input, out double result))
            {
                Console.WriteLine("Try again...");
                return ReadDouble();
            }
            return result;
        }
        public static int ReadInt()
        {
            string input = Console.ReadLine();
            if (!int.TryParse(input, out int result) || result < 1)
            {
                Console.WriteLine("Try again...");
                return ReadInt();
            }
            return result;
        }
    }
}
