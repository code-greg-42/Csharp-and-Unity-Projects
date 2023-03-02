using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechAcademyDR
{
    class Program
    {
        static void Main()
        {
            // opening message
            Console.WriteLine("The Tech Academy.");
            Console.WriteLine("Student Daily Report.");

            // questions + save inputs into variables
            Console.WriteLine("What is your name?");
            string studentName = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string currentCourse = Console.ReadLine();
            Console.WriteLine("What is your page number in the course?");
            string pageNumber = Console.ReadLine();
            int pageNum = Convert.ToInt32(pageNumber);
            Console.WriteLine("Do you need help with anything? Please answer true or false");
            string needsHelp = Console.ReadLine();
            bool helpNeeded = Convert.ToBoolean(needsHelp);
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string posExp = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string studentFeedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string hoursStudied = Console.ReadLine();
            int studyHours = Convert.ToInt32(hoursStudied);

            // closing message
            Console.WriteLine("Thank you for your answers, " + studentName + ". An instructor will respond to this shortly. Have a great day!");
            Console.WriteLine("Click the X in the top right to exit.");
            Console.ReadLine();
        }
    }
}
