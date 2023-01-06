using System;

namespace Inheritance.Demo.Classes
{
    public abstract class Person
    {
        private string firstName;

        public Person(string firstName)
            : this(firstName, null)
        {
        }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName
        {
            get => firstName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(value));
                }

                firstName = value;
            }
        }

        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                if (LastName == null)
                {
                    return FirstName;
                }

                return $"{FirstName} {LastName}";
            }
        }

        public virtual void Introduce()
        {
            Console.WriteLine($"Hello, my name is {FullName}.");
        }
    }
}
