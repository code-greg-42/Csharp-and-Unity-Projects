using System;

namespace AbstractClassAssignment
{
    public class Employee: Person, IQuittable
    {
        public int Id { get; set; }
        public override void SayName()
        {
            Console.WriteLine("Our next new employees name is: {0} {1}", FirstName, LastName);
        }
        public void Quit()
        {
            Console.WriteLine("Breaking News! Employee {0} {1} has just gotten up and walked out of the building!", FirstName, LastName);
        }
        public static bool operator== (Employee emp1, Employee emp2)
        {
            if (emp1.Id == emp2.Id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator!= (Employee emp1, Employee emp2)
        {
            if (emp1.Id != emp2.Id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
