using System;

namespace Step129Challenge
{
    class Program
    {
        static void Main()
        {
            // 1.
            Console.WriteLine("Input a number:");
            string numString1 = Console.ReadLine();
            int inputNum1 = Convert.ToInt32(numString1);
            Console.WriteLine("Your new number is " + (inputNum1 * 50));
            // 2.
            Console.WriteLine("Input another number:");
            string numString2 = Console.ReadLine();
            int inputNum2 = Convert.ToInt32(numString2);
            Console.WriteLine("Your second number is " + (inputNum2 + 25));
            // 3.
            Console.WriteLine("Input another number:");
            string numString3 = Console.ReadLine();
            int inputNum3 = Convert.ToInt32(numString3);
            Console.WriteLine("Your third number is " + (inputNum3 / 12.5));
            // 4.
            Console.WriteLine("Input another number:");
            string numString4 = Console.ReadLine();
            int inputNum4 = Convert.ToInt32(numString4);
            bool greaterThan = inputNum4 > 50;
            Console.WriteLine("Your latest input is greater than 50: " + greaterThan.ToString());
            // 5.
            Console.WriteLine("Input another number:");
            string numString5 = Console.ReadLine();
            int inputNum5 = Convert.ToInt32(numString5);
            Console.WriteLine("Your last number's remainder when dividing by 7 is: " + (inputNum5 % 7));
            Console.ReadLine();
        }
    }
}
