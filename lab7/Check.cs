using System;

namespace lab7
{
    static internal class Check
    {
        public static int ReadInt()
        {
            string input = Console.ReadLine();
            if (!int.TryParse(input, out int result) || result < 1 || result > 4)
            {
                Console.WriteLine("Try again...");
                return ReadInt();
            }
            return result;
        }
        public static string ReadUpper()
        {
            string input = Console.ReadLine();
            bool is_lower = false;
            foreach (var symb in input.ToCharArray())
            {
                if (char.IsLower(symb))
                {
                    is_lower = true;
                    break;
                }
            }
            if (is_lower || input.Replace(" ", "").Length < 1)
            {
                Console.WriteLine("Try again...");
                return ReadUpper();
            }
            return input;
        }
        public static string ReadString(int n)
        {
            string input = Console.ReadLine();
            if (input.Length > n)
            {
                Console.WriteLine("Try again...");
                return ReadString(n);
            }
            return input;
        }
        public static string ReadString()
        {
            string input = Console.ReadLine();
            if (input.Replace(" ", "").Length < 1)
            {
                Console.WriteLine("Try again...");
                return ReadString();
            }
            return input;
        }
    }
}
