using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment1
{
    static class ItsNowHalf
    {
        public static void HalfIt() {}

        public static int HalfIt(int x, out int res)
        {
            res = x / 2;
            return res;
        }
    }
}
