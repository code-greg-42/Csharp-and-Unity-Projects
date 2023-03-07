using System;

namespace AbstractClassAssignment
{
    public class Employee: Person
    {
        public override void SayName()
        {
            Console.WriteLine("Our next new employees name is: {0} {1}", FirstName, LastName);
        }
    }
}
