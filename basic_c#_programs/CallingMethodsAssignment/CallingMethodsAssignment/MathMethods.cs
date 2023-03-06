using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    class MathMethods
    {
        public static int RandomMultiply(int num1)
        {
            Random rand = new Random();
            int newInt = rand.Next(0, 1000) * num1;
            return newInt;
        }
        public static int RandomAdd(int num1)
        {
            Random rand = new Random();
            int newInt = rand.Next(0, 1000) + num1;
            return newInt;
        }
        public static int RandomSubtract(int num1)
        {
            Random rand = new Random();
            int newInt = rand.Next(0, 1000) - num1;
            return newInt;
        }
    }
}
