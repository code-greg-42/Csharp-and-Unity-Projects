using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step268StructChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Number num1 = new Number()
            {
                Amount = 9999
            };

            Console.WriteLine(num1.Amount);
            _ = Console.ReadLine();
        }
    }
}
