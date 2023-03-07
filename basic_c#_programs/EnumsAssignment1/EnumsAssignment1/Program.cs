using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsAssignment1
{
    class Program
    {
        static void Main()
        {
            try
            {
                // ask user for input
                Console.WriteLine("What day of the week is it?");
                // convert input to first letter caps, rest lower
                string userDay = Console.ReadLine().ToLower();
                string userDayCaps = char.ToUpper(userDay[0]) + userDay.Substring(1, userDay.Length - 1);
                // convert string input to enum
                DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), userDayCaps);
                int dayNum = (int)day;

                // print enum to console
                Console.WriteLine(day);
                Console.WriteLine(dayNum);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Please restart the program and enter an actual day of the week.");
            }
            finally
            {
                Console.WriteLine("Program Success. End of program. Press enter to exit.");
                _ = Console.ReadLine();
            }
        }
        enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
