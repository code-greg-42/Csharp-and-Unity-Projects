using System;

namespace AbstractClassAssignment
{
    class Program
    {
        static void Main()
        {
            Employee employee42 = new Employee() { FirstName = "Sample", LastName = "Student" };
            employee42.SayName();
            _ = Console.ReadLine();

            IQuittable employee43 = new Employee() { FirstName = "Peter", LastName = "Gibbons" };
            employee43.Quit();
            _ = Console.ReadLine();
        }
    }
}
