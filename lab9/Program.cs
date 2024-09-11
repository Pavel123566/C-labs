using System;

namespace lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            var planes = new planeArray();
            int choice;
            do
            {
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1. Ввести список самолётов");
                Console.WriteLine("2. Вывести список самолётов");
                Console.WriteLine("3. Отсортировать список записей");
                Console.WriteLine("4. Найти запись");
                Console.WriteLine("5. Выход");

                choice = Check.ReadInt();

                switch (choice)
                {
                    case 1:
                        planes.InputPlane();
                        break;
                    case 2:
                        planes.PrintPlanes();
                        break;
                    case 3:
                        planes.Sort();
                        break;
                    case 4:
                        planes.Search();
                        break;
                    case 5:
                        Console.WriteLine("Выход из программы.");
                        break;
                    default:
                        Console.WriteLine("Некорректный ввод. Попробуйте снова.");
                        break;
                }
            } while (choice != 5);
        }
    }
}
