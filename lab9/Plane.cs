using System;
using System.Linq;

namespace lab9
{
    enum FabricatorEnum { Fokker, Israel_Aircraft, Lancair }
    struct Plane
    {
        public string Destination { get; set; }
        public string Departure { get; set; }
        public FabricatorEnum Fabricator { get; set; }
    }

    class planeArray
    {
        private Plane[] planes = new Plane[0];

        public void InputPlane()
        {
            Console.WriteLine("Введите количество элементов: ");
            int count = Check.ReadInt(0, 999);
            planes = new Plane[count];
            for(int i = 0; i < planes.Length; i++)
            {
                Console.Write($"Введите пункт назначения: ");
                string destination = Check.ReadName();
                planes[i].Destination = destination;
                Console.Write($"Введите пункт отправления: ");
                string departure = Check.ReadName();
                planes[i].Departure = departure;
                Console.Write($"Введите производителя\n" +
                    $"1 - Fokker\n" +
                    $"2 - Israel_Aircraft\n" +
                    $"3 - Lancair\n");
                FabricatorEnum fabricator = Check.ReadFabricator();
                planes[i].Fabricator = fabricator;
            }
            
        }
        public void PrintPlanes()
        {
            if (planes.Length < 1)
            {
                Console.WriteLine("Список пуст.");
                return;
            }
            Console.WriteLine("Список записей:");
            foreach (var plane in planes)
            {
                Console.WriteLine($"Пункт назначения: {plane.Destination}\n" +
                    $"Пункт отправления: {plane.Departure}\n" +
                    $"Производитель {plane.Fabricator}\n");
            }
        }

        public void Sort()
        {
            if (planes.Length == 0)
            {
                Console.WriteLine("Список пуст.");
                return;
            }
            Array.Sort(planes, (x, y) => x.Destination.CompareTo(y.Destination));
            Console.WriteLine("Список записей успешно отсортирован!");
        }


        public void Search()
        {
            if (planes.Length == 0)
            {
                Console.WriteLine("Список пуст.");
                return;
            }
            while (true)
            {
                Console.Write("Введите пункт назначения: ");
                string destination = Check.ReadName();

                if (destination.Replace(" ", "").Length < 1)
                {
                    Console.WriteLine("Выход из поиска.");
                    break;
                }
                var is_founded = false;
                foreach (var plane in planes)
                {
                    if (plane.Destination == destination)
                    {
                        is_founded = true;
                        Console.WriteLine($"Найдена запись:\n" +
                            $"Пункт назначения: {plane.Destination}\n" +
                            $"Пункт отправления: {plane.Departure}\n" +
                            $"Производитель: {plane.Fabricator}\n");
                    }
                }

                if (!is_founded)
                {
                    Console.WriteLine($"Запись не найдена!");
                }
            }
        }
    }
}
