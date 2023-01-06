using Inheritance.Demo.Classes;
using System;

namespace Inheritance.Demo
{
    internal class Program
    {
        public static void Main()
        {
            const string firstName = "Vadzim", lastName = "Kurdzesau", company = "EPAM";

            #region Cannot create an instance of an abstact class

            //Person person = new Person(firstName, lastName);
            //Employee employee = new Employee(firstName, lastName, company);

            #endregion

            #region Admin doesn't override the Introduce() method - prints the Employee class version

            Admin admin = new Admin(firstName, lastName, company);
            //admin.Introduce();
            //admin.Work();

            #endregion

            #region Calling the Person Introduce() method version - output is the same (overrided version)

            //((Person)admin).Introduce();

            #endregion

            #region Manager replaces the Introduce() method
            
            Manager manager = new Manager(firstName, lastName, company);
            //manager.Introduce();
            //manager.Work();

            #endregion

            #region Calling the Employee and then, Person Introduce() method versions - the Employee's output

            //((Employee)manager).Introduce();
            //((Person)manager).Introduce();

            #endregion

            #region Developer overrides the Introduce() method

            Developer developer = new Developer(firstName, lastName, company);
            //developer.Introduce();

            #endregion

            #region Calls the base method inside

            //developer.Work();

            #endregion

            #region Calling the Employee and then, Person Introduce() method versions - the Developer's output (overrides it)

            //((Employee)developer).Introduce();
            //((Person)developer).Introduce();

            #endregion

            #region Benefits of the polymorphism

            //List<Person> people = new List<Person>()
            //{
            //    admin,
            //    manager,
            //    developer,
            //};

            //people.Add(new Admin($"###{firstName}###", $"###{lastName}###", $"###{company}###"));

            //int count = 0;
            //foreach (var person in people)
            //{
            //    PrintSeparationLine($"List element {count}");
            //    person.Introduce();
            //    count++;
            //}

            //PrintSeparationLine(string.Empty);

            //foreach (var employee in people)
            //{
            //    PrintEmployee(employee);
            //}

            #endregion
        }

        private static void PrintSeparationLine(string number)
        {
            Console.WriteLine($"=========={number}==========");
        }

        private static void PrintEmployee(Employee employee)
        {
            employee.Introduce();
            employee.Work();
        }
    }
}