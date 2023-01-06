using System;

namespace Inheritance.Demo.Classes
{
    public class Developer : Employee
    {
        public Developer(string firstName, string companyName)
            : base(firstName, companyName)
        {
        }

        public Developer(string firstName, string lastName, string companyName)
            : base(firstName, lastName, companyName)
        {
        }

        public override void Introduce()
        {
            base.Introduce();
            Console.WriteLine("Developer adds: 'I develop software'.");
        }

        public override void Work()
        {
            Console.WriteLine("Developer works!");
        }
    }
}
