using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    internal class MatrixWork
    {
        public double[][] matrix;

        public MatrixWork(double[][] matrix)
        {
            this.matrix = matrix;
        }
        public MatrixWork()
        {
            matrix = new double[10][];
            for (int i = 0; i < 10; i++)
            {
                matrix[i] = new double[10];
            }
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    matrix[i][j] = Math.Round(rnd.NextDouble() * 100, 2);
                }
            }
        }
        public MatrixWork(int num)
        {
            matrix = new double[10][];
            for (int i = 0; i < 10; i++)
            {
                matrix[i] = new double[10];
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    matrix[i][j] = num;
                }
            }

        }
        public void change()
        {
            double[][] newMatrix = matrix;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    double sum = 0;
                    int count = 0;
                    if (i - 1 >= 0)
                    {
                        sum += matrix[i - 1][j];
                        count++;
                    }
                    if (i + 1 < matrix.Length)
                    {
                        sum += matrix[i + 1][j];
                        count++;
                    }
                    if (j - 1 >= 0)
                    {
                        sum += matrix[i][j - 1];
                        count++;
                    }
                    if (j + 1 < matrix[i].Length)
                    {
                        sum += matrix[i][j + 1];
                        count++;
                    }
                    if (i - 1 >= 0 && j - 1 >= 0)
                    {
                        sum += matrix[i - 1][j - 1];
                        count++;
                    }
                    if (i - 1 >= 0 && j + 1 < matrix[i].Length)
                    {
                        sum += matrix[i - 1][j + 1];
                        count++;
                    }
                    if (i + 1 < matrix.Length && j - 1 >= 0)
                    {
                        sum += matrix[i + 1][j - 1];
                        count++;
                    }
                    if (i + 1 < matrix.Length && j + 1 < matrix[i].Length)
                    {
                        sum += matrix[i + 1][j + 1];
                        count++;
                    }
                    newMatrix[i][j] = Math.Round(sum / count, 2);
                }
            }
            matrix = newMatrix;
        }
        public double sum()
        {
            double sum = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i > j)
                    {
                        sum += Math.Abs(matrix[i][j]);
                    }
                }
            }
            return sum;
        }
        public void PrintMatrix()
        {
            foreach (var item in matrix)
            {
                foreach (var num in item)
                {
                    Console.Write($"{num} \t");
                }
                Console.WriteLine();
            }
        }
    }
}