using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace lab8
{
    internal class Regexx
    {
        
        public static void PrintInColors(string text)
        {
            string english_reg = @"\b[A-Za-z]+\b";
            string russian_reg = @"\b[А-Яа-я]+\b";
            string number_reg = @"\b\d+\b";

            Regex englishRegex = new Regex(english_reg);
            Regex russianRegex = new Regex(russian_reg);
            Regex numberRegex = new Regex(number_reg);

            foreach (string word in text.Split())
            {
                if (englishRegex.IsMatch(word))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                else if (russianRegex.IsMatch(word))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if (numberRegex.IsMatch(word))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }

                Console.Write(word + " ");
                Console.ResetColor();
            }
            Console.WriteLine();
        }
    }
}
