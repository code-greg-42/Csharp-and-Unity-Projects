using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step307DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            // print current time to console
            Console.WriteLine(DateTime.Now);

            // gather user input and convert to integer
            Console.WriteLine("Please enter a number.");
            int userNum = Convert.ToInt32(Console.ReadLine());

            // add user input number of hours to the current time and print to console
            Console.WriteLine("In {0} hours it will be {1}", userNum, DateTime.Now.AddHours(userNum));

            // prevent program from auto-closing
            _ = Console.ReadLine();
        }
    }
}
