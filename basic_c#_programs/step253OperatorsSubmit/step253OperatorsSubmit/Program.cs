using System;
using System.Collections.Generic;

namespace step253OperatorsSubmit
{
    class Program
    {
        static void Main()
        {
            Employee employee42 = new Employee() { FirstName = "Sample", LastName = "Student", Id = 42 };

            Employee employee47 = new Employee() { FirstName = "Frederick", LastName = "Applebottom", Id = 47 };

            Console.WriteLine("Are Frederick Applebottom and Sample Student the same employee?");
            bool same_emp1 = employee42 == employee47;
            Console.WriteLine(same_emp1);
            Console.WriteLine("How about Frederick Applebottom and Frederick Applebottom?");
            bool same_emp2 = employee47 == employee47;
            Console.WriteLine(same_emp2);
            _ = Console.ReadLine();
        }
    }
}
