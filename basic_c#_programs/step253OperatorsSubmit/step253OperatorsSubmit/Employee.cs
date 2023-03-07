using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    public class Employee<T>: Person, IQuittable
    {
        public int Id { get; set; }
        public List<T> Things { get; set; }
        public override void SayName()
        {
            Console.WriteLine("Our next new employees name is: {0} {1}", FirstName, LastName);
        }
        public void Quit()
        {
            Console.WriteLine("Breaking News! Employee {0} {1} has just gotten up and walked out of the building!", FirstName, LastName);
        }

        // this is needed for a previous step, but breaks when changing employee to generic

        //public static bool operator== (Employee emp1, Employee emp2)
        //{
        //    if (emp1.Id == emp2.Id)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        //public static bool operator!= (Employee emp1, Employee emp2)
        //{
        //    if (emp1.Id != emp2.Id)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
    }
}
