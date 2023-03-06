using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment4
{
    class MathClass
    {
        public static void Method1(int x, int y)
        {
            x += 42;
            Console.WriteLine("Second parameter: {0}", y);
        }
    }
}
