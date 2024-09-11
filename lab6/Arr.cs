using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    internal class Arr
    {
        private double[] array;
        public Arr(int count)
        {
            array = new double[count];
        }
        public double[] Array
        {
            set { array = value; }
            get { return array; }
        }

        public double max()
        {
            double max = array[0];
            foreach (var item in array)
            {
                if (item > max)
                {
                    max = item;
                }
            }
            return max;
        }

        public double sum()
        {
            double sum = 0;
            int first_positive_idx = -1, second_positive_idx = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    if (first_positive_idx == -1)
                    {
                        first_positive_idx = i;
                    }
                    else if (first_positive_idx != -1 && second_positive_idx == -1)
                    {
                        second_positive_idx = i;
                    }
                }
            }
            for (int i = first_positive_idx + 1; i < second_positive_idx; i++)
            {
                sum += array[i];
            }
            return sum;
        }

        public void change()
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != 0)
                {
                    array[count] = array[i];
                    count++;
                }
            }
            while (count < array.Length)
            {
                array[count] = 0;
                count++;
            }
        }
    }
}
