using System;
using System.Linq;

namespace lab9
{
    static internal class Check
    {
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
            if (!input.All(char.IsLetter) || input.ToUpper()[0] != input[0])
            {
                Console.WriteLine("Try again...");
                return ReadName();
            }
            return input;
        }
        public static FabricatorEnum ReadFabricator()
        {
            string input = Console.ReadLine();
            if (!int.TryParse(input, out int result) || result < 1 || result > 3)
            {
                Console.WriteLine("Try again...");
                return ReadFabricator();
            }
            result = result - 1;
            return (FabricatorEnum)result;
        }
    }
}
