using System;

namespace Inheritance.Demo.Classes
{
    public class Manager : Employee
    {
        public Manager(string firstName, string companyName) : base(firstName, companyName)
        {
        }

        public Manager(string firstName, string lastName, string companyName) : base(firstName, lastName, companyName)
        {
        }

        public new void Introduce()
        {
            Console.WriteLine($"Hello, my name is {FullName}. I work in \"{CompanyName}\". I'm a manager.");
        }

        public override void Work()
        {
            Console.WriteLine("Manager is not working!");
        }
    }
}