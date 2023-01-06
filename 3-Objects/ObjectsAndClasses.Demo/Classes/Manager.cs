using System;

namespace ObjectsAndClasses.Demo.Classes;

public class Manager
{
    private static string companyName;
    private string firstName;

    public static string CompanyName 
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
            return $"{FirstName}{(LastName == null ? string.Empty : $" {LastName}")}";
        }
    }

    static Manager()
    {
        CompanyName = "EPAM";
    }

    public Manager(string firstName)
        : this(firstName, null)
    {
    }

    public Manager(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    // Methods
    public void Introduce()
    {
        Console.WriteLine($"Hello, my name is {FullName}. I work in \"{CompanyName}\".");
    }
}
