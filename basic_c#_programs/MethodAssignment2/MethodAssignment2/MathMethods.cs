using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment2
{
    class MathMethods
    {
        public int Math1(int num1)
        {
            return num1 + 42;
        }
        public int Math2(decimal dec1)
        {
            return Convert.ToInt32(dec1) + 42;
        }
        public int Math3(string string1)
        {
            try
            {
                return Convert.ToInt32(string1) * 42;
            } catch
            {
                return 0;
            }
        }
    }
}
