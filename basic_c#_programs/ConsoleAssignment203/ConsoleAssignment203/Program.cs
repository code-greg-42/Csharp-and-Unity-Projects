using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAssignment203
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = new List<int>() { 200, 300, 400, 420, 500, 70, 20, 9000, 42 };
            Console.WriteLine("Enter a non-zero integer that we'll use as a divisor:");
            bool usedCorrectly = false;

            while (!usedCorrectly) {
                try
                {
                    int userNum = Convert.ToInt32(Console.ReadLine());

                    // divide and display loop
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        float quotient = numbers[i] / userNum;
                        Console.WriteLine(quotient);
                    }
                    usedCorrectly = true;
                    Console.WriteLine("Press enter to exit.");
                    _ = Console.ReadLine();
                } catch (FormatException ex)
                {
                    Console.WriteLine(ex);
                    Console.WriteLine("Please enter a valid non-zero integer:");
                } catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex);
                    Console.WriteLine("Please make sure the integer is non-zero. Enter again:");
                } finally
                {
                    Console.WriteLine("End of 1st attempt. Program continues if input requirements are not met.");
                }
            }
        }
    }
}
