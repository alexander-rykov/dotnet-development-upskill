using System;
using System.Globalization;

namespace WorkingWithDateTime.Demo;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine($"Current date: {DateTime.Now}.");
        Console.WriteLine($"Current date: {DateTime.UtcNow}.");

        // All DateTime formats: https://learn.microsoft.com/en-us/dotnet/standard/base-types/custom-date-and-time-format-strings
        Console.WriteLine($"Current date: {DateTime.Now:yyyy}.");
        Console.WriteLine($"Current date: {DateTime.Now:dd MMM yy}.");
        Console.WriteLine($"Current date: {DateTime.Now:dddd}.");

        // CultureInfo with dates
        CultureInfo polishCultureInfo = new CultureInfo("pl-PL");
        CultureInfo americanCultureInfo = new CultureInfo("en-US");
        Console.WriteLine($"Current date with Polish culture: {DateTime.Now.ToString(polishCultureInfo)}.");
        Console.WriteLine($"Current date with USA culture: {DateTime.Now.ToString(americanCultureInfo)}.");

        // CultureInfo with money
        const decimal cash = 15.48M;
        Console.WriteLine($"Price in Poland: {cash.ToString("C", polishCultureInfo)}.");
        Console.WriteLine($"Price in USA: {cash.ToString("C", americanCultureInfo)}.");

        Console.WriteLine($"Price in Poland without globally set culture: {cash.ToString("C")}.");
        CultureInfo.CurrentCulture = polishCultureInfo;
        Console.WriteLine($"Price in Poland with globally set culture: {cash.ToString("C")}.");

        //CultureInfo.InvariantCulture
        Console.WriteLine($"Price with InvariantCulture: {cash.ToString("C", CultureInfo.InvariantCulture)}.");
    }
}