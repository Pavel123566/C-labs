using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    internal class StringWork
    {
        public static string task1(string S, string S0)
        {
            int last_entry = S.LastIndexOf(S0);
            if (last_entry == -1) return S;
            return S.Remove(last_entry, S0.Length);

        }
        public static string task2(string S)
        {
            S = S.ToUpper();
            string[] array = S.Split(' ');
            string[] new_array = new string[array.Length];
            for(int i = 0; i < array.Length; i++)
            {
                string str = array[i];
                char symbol = str[str.Length - 1];
                str = str.Replace(symbol, '.');
                str = str.Remove(str.Length - 1);
                new_array[i] = (str + symbol);
            }
            return string.Join(" ", new_array);
        }
        public static string task3(string S)
        {
            var array = S.ToCharArray();
            StringBuilder new_string = new StringBuilder();
            for(int i = 0; i < array.Length; i++)
            {
                if(i%2==1)
                {
                    new_string.Append(array[i]);
                }
            }
            for(int i = array.Length - 1; i >= 0; i--)
            {
                if(i%2==0)
                {
                    new_string.Append(array[i]);
                }
            }
            return new_string.ToString();
        }
    }
}
