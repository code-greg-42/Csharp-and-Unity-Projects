using System;

namespace AbstractClassAssignment
{
    class Program
    {
        static void Main()
        {
            Employee employee42 = new Employee() { FirstName = "Sample", LastName = "Student", Id = 42 };
            employee42.SayName();
            _ = Console.ReadLine();

            Employee employee47 = new Employee() { FirstName = "Frederick", LastName = "Applebottom", Id = 47 };

            IQuittable employee43 = new Employee() { FirstName = "Peter", LastName = "Gibbons", Id = 43 };
            employee43.Quit();
            _ = Console.ReadLine();

            Console.WriteLine("Are Frederick Applebottom and Sample Student the same employee?");
            bool same_emp = employee42 == employee47;
            Console.WriteLine(same_emp);
            _ = Console.ReadLine();
        }
    }
}
