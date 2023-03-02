using System;

namespace AnonIncomeComparison
{
    class Program
    {
        static void Main()
        {
            // title message
            Console.WriteLine("Anonymous Income Comparison Program");
            // person 1 input
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate:");
            string hourlyRate1 = Console.ReadLine();
            Console.WriteLine("Hours worked per week:");
            string hoursWorked1 = Console.ReadLine();
            // person 2 input
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate:");
            string hourlyRate2 = Console.ReadLine();
            Console.WriteLine("Hours worked per week:");
            string hoursWorked2 = Console.ReadLine();

            // math done here (salaries based on 52 weeks)
            double sal1 = Convert.ToDouble(hourlyRate1) * Convert.ToDouble(hoursWorked1) * 52;
            double sal2 = Convert.ToDouble(hourlyRate2) * Convert.ToDouble(hoursWorked2) * 52;
            bool p1MakesMore = sal1 > sal2;

            // print results
            Console.WriteLine("Annual salary of Person 1:");
            Console.WriteLine(sal1);
            Console.WriteLine("Annual salary of Person 2:");
            Console.WriteLine(sal2);
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(p1MakesMore);
            Console.ReadLine();
        }
    }
}
