using System;
using System.Linq;

namespace lab10
{
    static internal class Check
    {
        public static bool ReadBool()
        {
            string input = Console.ReadLine();
            switch (input)
            {
                case "+":
                    return true;
                case "-":
                    return false;
                default:
                    Console.WriteLine("Try again...");
                    return ReadBool();
            }
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
        public static string ReadListOfStrings(string[] list)
        {
            string input = Console.ReadLine();
            string[] inputList = input.Split(' ');
            if (inputList.Length < 1)
            {
                Console.WriteLine("Try again...");
                return ReadListOfStrings(list);
            }
            foreach (string item in inputList)
            {
                if (!list.Contains(item))
                {
                    Console.WriteLine("Try again...");
                    return ReadListOfStrings(list);
                }
            }
            return input;
        }
        public static int ReadYear()
        {
            string input = Console.ReadLine();
            if (!int.TryParse(input, out int result) || result > DateTime.Now.Year || result < 1970)
            {
                Console.WriteLine("Try again...");
                return ReadYear();
            }
            return result;
        }
        public static string ReadStringWithNumbers()
        {
            string input = Console.ReadLine();
            if (input.Replace(" ", "").Length < 1 || !input.Any(char.IsLetterOrDigit))
            {
                Console.WriteLine("Try again...");
                return ReadStringWithNumbers();
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
            if (input.Replace(" ", "").Length < 1 || !input.All(char.IsLetter))
            {
                Console.WriteLine("Try again...");
                return ReadName();
            }
            return input;
        }
        
        public static PhoneCaseType ReadPhoneCase()
        {
            string input = Console.ReadLine();
            if (!int.TryParse(input, out int result) || result < 1 || result > 3)
            {
                Console.WriteLine("Try again...");
                return ReadPhoneCase();
            }
            result = result - 1;
            return (PhoneCaseType)result;
        }
        
        public static TouchScreenType ReadTouchScreen()
        {
            string input = Console.ReadLine();
            if (!int.TryParse(input, out int result) || result < 1 || result > 3)
            {
                Console.WriteLine("Try again...");
                return ReadTouchScreen();
            }
            result = result - 1;
            return (TouchScreenType)result;
        }
    }
}
