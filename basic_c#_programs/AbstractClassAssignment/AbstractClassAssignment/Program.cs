using System;
using System.Collections.Generic;

namespace AbstractClassAssignment
{
    class Program
    {
        static void Main()
        {

            Employee<string> employee1 = new Employee<string>();
            employee1.Things = new List<string>()
            {
                "Laptop",
                "Coffee Mug",
                "Keyboard",
                "Mouse",
                "Mousepad",
                "Notebook"
            };

            Employee<int> employee2 = new Employee<int>();
            employee2.Things = new List<int>() { 1, 2, 3, 4, 5, 42, 7, 9, 47, 49 };

            
            foreach (string thing in employee1.Things)
            {
                Console.WriteLine(thing);
            }
            foreach (int thing in employee2.Things)
            {
                Console.WriteLine(thing);
            }

            _ = Console.ReadLine();

            // this is needed for previous step - breaks when changing employee class to <T>
            //Employee employee42 = new Employee() { FirstName = "Sample", LastName = "Student", Id = 42 };
            //employee42.SayName();
            //_ = Console.ReadLine();

            //Employee employee47 = new Employee() { FirstName = "Frederick", LastName = "Applebottom", Id = 47 };

            //IQuittable employee43 = new Employee() { FirstName = "Peter", LastName = "Gibbons", Id = 43 };
            //employee43.Quit();
            //_ = Console.ReadLine();

            //Console.WriteLine("Are Frederick Applebottom and Sample Student the same employee?");
            //bool same_emp = employee42 == employee47;
            //Console.WriteLine(same_emp);
            //_ = Console.ReadLine();
        }
    }
}
