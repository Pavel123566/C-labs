using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    internal class Menus
    {
        public static void MainMenu()
        {
            bool is_enabled = true;
            while (is_enabled)
            {
                Console.WriteLine("Choose task to work with: \n" +
                "1 - Task 1\n" +
                "2 - Task 2\n" +
                "3 - exit");
                int choice = Check.ReadInt();
                switch (choice)
                {
                    case 1:
                        Task1();
                        break;
                    case 2:
                        Task2();
                        break;
                    case 3:
                        is_enabled = false;
                        break;
                }
            }
        }
        static void Task1()
        {   
            bool is_enabled = true;
            while (is_enabled)
            {
                Console.WriteLine("Choose method: \n" +
                "1 - Factorial\n" +
                "2 - Average\n" +
                "3 - Square\n" +
                "4 - exit");
                int choice = Check.ReadInt();
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Input number: ");
                        int num = Check.ReadInt();
                        Console.WriteLine($"Factorial of {num}={Ariphmetic.factorial(num)}");
                        break;
                    case 2:
                        Console.WriteLine("Input count of numbers: ");
                        int count = Check.ReadInt(1,10000);
                        int[] numbers = new int[count];
                        for (int i = 0; i < count; i++)
                        {
                            Console.WriteLine($"Input {i} num: ");
                            int number = Check.ReadInt();
                            numbers[i] = number;
                        }
                        Console.WriteLine($"Average is {Ariphmetic.average(numbers)}");
                        break;
                    case 3:
                        Console.WriteLine("Input a:");
                        int a = Check.ReadInt();
                        Console.WriteLine("Input b:");
                        int b = Check.ReadInt();
                        Console.WriteLine("Input c:");
                        int c = Check.ReadInt();
                        var roots = Ariphmetic.square(a, b, c);
                        if (roots == null)
                        {
                            Console.WriteLine("No roots");
                        }
                        else if (roots.Length == 1)
                        {
                            Console.WriteLine($"Only one root: {roots[0]}");
                        }
                        else
                        {
                            Console.WriteLine($"1st root: {roots[0]}\n2nd root: {roots[1]}");
                        }
                        break;
                    case 4:
                        is_enabled = false;
                        break;
                    default:
                        Console.WriteLine("Smth wrong.");
                        break;
                }
            }
        }
        static void Task2()
        {
            Person person = new Person();
            bool is_enabled = true;
            while (is_enabled)
            {
                Console.WriteLine("Choose class method: \n" +
                "1 - Default constructor\n" +
                "2 - Set Name\n" +
                "3 - Set Age\n" +
                "4 - Set Sex\n" +
                "5 - Constructor with parameters\n" +
                "6 - Print info\n" +
                "7 - exit");
                int choice = Check.ReadInt();
                string name;
                int age;
                char sex;
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Initialized");
                        person = new Person();
                        Console.WriteLine(person.ToString());
                        break;
                    case 2:
                        Console.WriteLine("Input name: ");
                        name = Check.ReadName();
                        person.Name = name;
                        break;
                    case 3:
                        Console.WriteLine("Input age: ");
                        age = Check.ReadInt(1, 150);
                        person.Age = age;
                        break;
                    case 4:
                        Console.WriteLine("Choose sex (M or F): ");
                        sex = Check.ReadSex();
                        person.Sex = sex;
                        break;
                    case 5:
                        Console.WriteLine("Input name: ");
                        name = Check.ReadName();
                        Console.WriteLine("Input age: ");
                        age = Check.ReadInt(1, 150);
                        Console.WriteLine("Choose sex (M or F): ");
                        sex = Check.ReadSex();
                        person = new Person(name, age, sex);
                        Console.WriteLine(person.ToString());
                        break;
                    case 6:
                        Console.WriteLine(person.ToString());
                        break;
                    case 7:
                        is_enabled = false;
                        break;
                }
            }
        }
    }
}