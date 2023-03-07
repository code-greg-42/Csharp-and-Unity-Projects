using System;
using System.Collections.Generic;
using System.Linq;

namespace step273Lambda
{
    class Program
    {
        static void Main()
        {
            Employee employee0 = new Employee() { FirstName = "Carmelo", LastName = "Anthony", Id = 0};
            Employee employee1 = new Employee() { FirstName = "Jalen", LastName = "Hurts", Id = 1};
            Employee employee2 = new Employee() { FirstName = "Ty", LastName = "Cobb", Id = 2};
            Employee employee3 = new Employee() { FirstName = "Babe", LastName = "Ruth", Id = 3};
            Employee employee4 = new Employee() { FirstName = "Lou", LastName = "Gherig", Id = 4};
            Employee employee5 = new Employee() { FirstName = "Joe", LastName = "Dimaggio", Id = 5};
            Employee employee6 = new Employee() { FirstName = "Bill", LastName = "Russell", Id = 6};
            Employee employee7 = new Employee() { FirstName = "Joe", LastName = "Mauer", Id = 7};
            Employee employee8 = new Employee() { FirstName = "Kobe", LastName = "Bryant", Id = 8};
            Employee employee9 = new Employee() { FirstName = "Ted", LastName = "Williams", Id = 9};

            List<Employee> employees = new List<Employee>();
            employees.Add(employee0);
            employees.Add(employee1);
            employees.Add(employee2);
            employees.Add(employee3);
            employees.Add(employee4);
            employees.Add(employee5);
            employees.Add(employee6);
            employees.Add(employee7);
            employees.Add(employee8);
            employees.Add(employee9);

            List<Employee> employeesNamedJoe = new List<Employee>();

            foreach (Employee emp in employees)
            {
                if (emp.FirstName == "Joe")
                {
                    employeesNamedJoe.Add(emp);
                }
            }

            List<Employee> employeesNamedJoe2 = employees.Where(x => x.FirstName == "Joe").ToList();
            
            List<Employee> employeesIdOver5 = employees.Where(x => x.Id > 5).ToList();

            Console.WriteLine(employeesNamedJoe2[0].FirstName);
            Console.WriteLine(employeesIdOver5[0].Id);
            _ = Console.ReadLine();
            

            //older code
            //Employee<string> employee1 = new Employee<string>();
            //employee1.Things = new List<string>()
            //{
            //    "Laptop",
             //   "Coffee Mug",
            //    "Keyboard",
            //    "Mouse",
            //    "Mousepad",
            //    "Notebook"
            //};

            //Employee<int> employee2 = new Employee<int>();
            //employee2.Things = new List<int>() { 1, 2, 3, 4, 5, 42, 7, 9, 47, 49 };

            
            //foreach (string thing in employee1.Things)
            //{
              //  Console.WriteLine(thing);
            //}
            //foreach (int thing in employee2.Things)
            //{
              //  Console.WriteLine(thing);
            //}

            //_ = Console.ReadLine();

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
