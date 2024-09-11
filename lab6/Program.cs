using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input count of elements in array:");
            int count = Check.ReadInt();
            Arr arr = new Arr(count);
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Input {i} element:");
                arr.Array[i] = Check.ReadDouble();
            }
            Console.WriteLine($"Max element: {arr.max()}");
            Console.WriteLine($"Sum of elements between first and second positive elements: {arr.sum()}");
            arr.change();
            Console.WriteLine("Changed array:");
            foreach (var item in arr.Array)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("\n----------");
            MatrixWork matrix = new MatrixWork();
            Console.WriteLine("Matrix:");
            matrix.PrintMatrix();
            matrix.change();
            Console.WriteLine("Changed matrix:");
            matrix.PrintMatrix();
            Console.WriteLine($"Sum of elements below main diagonal: {matrix.sum()}");
        }
    }
}
