using System;

namespace ObjectsAndClasses.Demo.Classes;

public class Employee
{
    #region Class state

    private string firstName;
    private string companyName;

    #endregion

    #region Class behaviour

    // Constructors
    public Employee(string firstName, string companyName)
        : this(firstName, null, companyName)
    {
    }

    public Employee(string firstName, string lastName, string companyName)
    {
        SetFirstName(firstName);
        LastName = lastName;
        CompanyName = companyName;
    }

    // Properties/methods
    public string GetFirstName()
    {
        return firstName;
    }

    public void SetFirstName(string firstName)
    {
        if (string.IsNullOrWhiteSpace(firstName))
        {
            throw new ArgumentNullException(nameof(firstName));
        }

        this.firstName = firstName;
    }

    // Auto-implemented property
    public string LastName { get; set; }

    public string FullName
    {
        get
        {
            if (LastName == null)
            {
                return GetFirstName();
            }

            return $"{GetFirstName()} {LastName}";
        }
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

    // Methods
    public void Introduce()
    {
        Console.WriteLine($"Hello, my name is {FullName}. I work in \"{CompanyName}\".");
    }

    #endregion
}
