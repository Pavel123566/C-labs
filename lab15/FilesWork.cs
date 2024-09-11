using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab15
{
    internal class FilesWork
    {
        private static string Path1 = @"D:\c++\labs\lab15\lab15\files\task1.txt";
        private static string Path2 = @"D:\c++\labs\lab15\lab15\files\task2.txt";
        public static void Task1()
        {
            string[] strings = System.IO.File.ReadAllLines(Path1);
            if(strings.Length < 1)
            {

                Console.WriteLine("File is empty");
                return;
            }
            foreach(var str in strings)
            {
                var sentences = str.Split('.');
                foreach(var sentence in sentences)
                {
                    Console.WriteLine("Input word: ");
                    string word = Console.ReadLine();
                    Console.WriteLine($"{sentence}\n\nCount of {word}: {sentence.Split(' ').Count(x => x == word)}");
                }
            }
        }
        public static void Task2()
        {
            string[] strings = System.IO.File.ReadAllLines(Path2);
            if (strings.Length < 1)
            {

                Console.WriteLine("File is empty");
                return;
            }
            ISet<int> ints = new HashSet<int>();
            foreach (var str in strings)
            {
                var nums = str.Split(' ');
                foreach (var num in nums)
                {
                    if (int.TryParse(num, out int number))
                    {
                        ints.Add(number);
                    }
                }
            }
            foreach (var num in ints)
            {
                Console.Write($"{num} ");
            }
        }
    }
}
