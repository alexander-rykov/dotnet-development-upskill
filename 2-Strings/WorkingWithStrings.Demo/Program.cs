using System;

namespace WorkingWithStrings.Demo;

public class Program
{
    private static void Main()
    {
        // String declaration
        string sourceMessage = "    Hello, World!    ";

        // Getting the string length
        // String concatenation via '+' operator
        int messageLength = sourceMessage.Length;
        Console.WriteLine("Message length is " + messageLength);

        PrintSeparationLine();

        // Accessing string characters by index
        // String concatenation via string.Concat
        for (int i = 0; i < messageLength; i++)
        {
            string message = string.Concat(i, ") ", sourceMessage[i]);
            Console.WriteLine(message);
        }

        PrintSeparationLine();

        DemonstateStringTrimming(sourceMessage);

        // String is passed by value to methods
        Console.WriteLine(sourceMessage);

        PrintSeparationLine();

        //                                      Start index, number of characters to remove
        string stringWithoutComma = sourceMessage.Remove(9, 1);
        Console.WriteLine(stringWithoutComma);

        //                                                Start index, string to insert
        string stringWithInsertedString = stringWithoutComma.Insert(9, sourceMessage);
        Console.WriteLine(stringWithInsertedString);

        PrintSeparationLine();
    }

    private static void DemonstateStringTrimming(string sourceMessage)
    {
        // String trimming and string interpolation/string.Format
        string trimmedMessage = sourceMessage.Trim();
        Console.WriteLine($"The source message '{sourceMessage}' has been trimmed to '{trimmedMessage}'.");

        sourceMessage = "####SpamMessage###";
        string anotherTrimmedMessage = sourceMessage.Trim('#');
        Console.WriteLine(string.Format("The source message '{0}' has been trimmed to '{1}'.", sourceMessage, anotherTrimmedMessage));
        PrintSeparationLine();
    }


    private static void PrintSeparationLine()
    {
        Console.WriteLine("==============================================");
    }
}