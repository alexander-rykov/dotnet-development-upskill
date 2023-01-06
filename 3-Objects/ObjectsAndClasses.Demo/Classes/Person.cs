using System;

namespace ObjectsAndClasses.Demo.Classes;

public class Person
{
    #region Class state

    public string firstName;
    public string lastName;

    #endregion

    #region Class behaviour

    // Methods
    public void Introduce()
    {
        Console.WriteLine($"Hello, my name is {firstName} {lastName}.");
    }

    #endregion
}
