using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethObjAssign1
{
    class Program
    {
        static void Main()
        {
            //Person person = new Person() { FirstName = "Greg", LastName = "Andersson" };
            //person.SayName();
            //_ = Console.ReadLine();

            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };
            employee.SayName();
            _ = Console.ReadLine();
        }
    }
}
