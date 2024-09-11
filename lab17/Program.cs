using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BusList bus = new BusList();
            while(true)
            {
                bus.Menu();
            }
        }
    }
}
