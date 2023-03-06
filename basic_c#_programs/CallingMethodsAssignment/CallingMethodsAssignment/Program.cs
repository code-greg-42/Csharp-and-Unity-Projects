using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    class Program
    {
        static void Main()
        {
            // user inputs number
            Console.WriteLine("Please enter your favorite integer and get ready to roll the dice: ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            // use methods to return different integer
            int num1 = MathMethods.RandomMultiply(userInput);
            // print new integer to screen
            Console.WriteLine("Random Math 1: Your result is " + num1);
            int num2 = MathMethods.RandomAdd(userInput);
            Console.WriteLine("Random Math 2: Your result is " + num2);
            int num3 = MathMethods.RandomSubtract(userInput);
            Console.WriteLine("Random Math 3: Your result is " + num3);
            // keep program running until user closes it
            _ = Console.ReadLine();
        }
    }
}
