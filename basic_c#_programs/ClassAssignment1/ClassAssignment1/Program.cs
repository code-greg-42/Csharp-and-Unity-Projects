using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number:");
            string userInput = Console.ReadLine();
            try
            {
                int userNum = Convert.ToInt32(userInput);
                ItsNowHalf.HalfIt(userNum, out int res);
                Console.WriteLine("Your new number is: {0}", res);
            }
            catch
            {
                Console.WriteLine("That is not a valid number.");
            }
            Console.WriteLine("Program end. Press enter to exit");
            _ = Console.ReadLine();
        }
    }
}
