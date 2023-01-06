using System;

namespace ObjectsAndClasses.Demo.Classes;

public class Admin
{
    #region Class state

    public string firstName;
    public string lastName;

    #endregion

    #region Class behaviour

    // Constructors
    public Admin(string firstName, string lastName)
    {
        this.firstName = firstName;
        this.lastName = lastName;
    }

    // Methods
    public void Introduce()
    {
        Console.WriteLine($"Hello, my name is {firstName} {lastName}.");
    }

    #endregion
}
