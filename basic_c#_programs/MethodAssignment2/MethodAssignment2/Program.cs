using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment2
{
    class Program
    {
        static void Main()
        {
            // instantiate mathmethods class
            MathMethods mathObj = new MathMethods();
            // while loop to repeat until user correctly enters a number
            bool validatedNum = false;
            while (!validatedNum) {
                Console.WriteLine("Please enter your favorite number:");
                string userInput = Console.ReadLine();
                try
                {
                    int favNum = Convert.ToInt32(userInput);
                    int newNum1 = mathObj.Math1(favNum);
                    validatedNum = true;
                    Console.WriteLine("Your new favorite number is {0}. Press enter to continue.", newNum1);
                }
                catch
                {
                    Console.WriteLine("Please enter a valid integer.");
                }
            }
            _ = Console.ReadLine();

            // while loop again for decimal
            bool validatedDec = false;
            while (!validatedDec)
            {
                Console.WriteLine("Please enter your favorite decimal:");
                string userInput2 = Console.ReadLine();
                try
                {
                    decimal favDec = Convert.ToDecimal(userInput2);
                    int newDec1 = mathObj.Math2(favDec);
                    validatedDec = true;
                    Console.WriteLine("Decimals are annoying. Here's a new integer instead: {0}. Press enter to continue.", newDec1);
                }
                catch
                {
                    Console.WriteLine("Please enter a valid decimal.");
                }
            }
            _ = Console.ReadLine();

            // while loop again until string is entered
            bool validatedString = false;
            while (!validatedString)
            {
                Console.WriteLine("Please enter your second favorite number:");
                string userInput2 = Console.ReadLine();
                int convertedNum1 = mathObj.Math3(userInput2);
                if (convertedNum1 != 0)
                {
                    validatedString = true;
                    Console.WriteLine("Your new second favorite number is now:{0}. Program End. Press enter to exit.", convertedNum1);
                }
                else
                {
                    Console.WriteLine("Please enter a valid integer.");
                }
            }
            _ = Console.ReadLine();
        }
    }
}
