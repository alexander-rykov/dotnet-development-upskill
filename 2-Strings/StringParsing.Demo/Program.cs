using System;

namespace StringParsing.Demo;

public class Program
{
    private static void Main(string[] args)
    {
        const string message = "Hello, World!";
        if (args.Length != 2)
        {
            Console.WriteLine("The number of arguments must equal 2.");
            return;
        }

        string numberOfTimesString = args[0], shouldUpperCaseString = args[1];

        // TryParse, out parameters
        bool isInteger = int.TryParse(numberOfTimesString, out int numberOfMessages);
        if (!isInteger)
        {
            Console.WriteLine("First parameter must be an integer.");
            return;
        }

        bool shouldUpperCase = bool.Parse(shouldUpperCaseString);

        for (int i = 0; i < numberOfMessages; i++)
        {
            Console.WriteLine(shouldUpperCase ? message.ToUpper() : message);
        }
    }
}