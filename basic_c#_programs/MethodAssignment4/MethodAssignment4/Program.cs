using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment4
{
    class Program
    {
        static void Main()
        {
            MathClass obj1 = new MathClass();
            obj1.Method1(19, 42);
            obj1.Method1(x: 19, y: 42);
            _ = Console.ReadLine();
        }
    }
}
