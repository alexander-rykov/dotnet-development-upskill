using System;

namespace Inheritance.Demo.Classes
{
    public class Admin : Employee
    {
        public Admin(string firstName, string companyName)
            : base(firstName, companyName)
        {
        }

        public Admin(string firstName, string lastName, string companyName)
            : base(firstName, lastName, companyName)
        {
        }

        // Doesn't override the Introduce() method

        public override void Work()
        {
            Console.WriteLine("Admin is working!");
        }
    }
}
