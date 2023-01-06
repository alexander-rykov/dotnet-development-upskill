using System;

namespace Inheritance.Demo.Classes
{
    public abstract class Employee : Person
    {
        private string companyName;

        public Employee(string firstName, string companyName)
            : this(firstName, null, companyName)
        {
        }

        public Employee(string firstName, string lastName, string companyName)
            : base(firstName, lastName)
        {
            CompanyName = companyName;
        }

        public string CompanyName
        {
            get => companyName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(value));
                }

                companyName = value;
            }
        }

        public override void Introduce()
        {
            Console.WriteLine($"Hello, my name is {FullName}. I work in \"{CompanyName}\".");
        }

        public abstract void Work();
    }

}