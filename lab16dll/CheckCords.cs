using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab16dll
{
    public static class CheckCords
    {
        public static bool check(double x, double y) 
        {
            if ((x <= -1 || x >= 2) && y >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
