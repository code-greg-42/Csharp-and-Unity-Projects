using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment3
{
    class Program
    {
        static void Main()
        {
            int intResult;
            Console.WriteLine("You will be asked to enter 2 numbers. Entering #1 is required. If you do not wish to enter #2, leave it blank.");
            Console.WriteLine("Please enter #1:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter #2 if you wish, or press enter to skip:");
            string input2 = Console.ReadLine();
            if (input2 != "")
            {
                int num2 = Convert.ToInt32(input2);
                intResult = GenericMethods.Method1(num1, num2);
            }
            else
            {
                intResult = GenericMethods.Method1(num1);
            }
            Console.WriteLine("The result of this method is: {0}", intResult);
            Console.WriteLine("End of program. Press enter to exit.");
            _ = Console.ReadLine();
        }
    }
}
