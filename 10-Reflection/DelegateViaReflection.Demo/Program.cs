using System.Reflection;

namespace DelegateViaReflection.Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var methodToCall = typeof(Program).GetMethod("PrintMessage", BindingFlags.NonPublic | BindingFlags.Static)!;
            var customDelegate = new CustomDelegateImplementation() { Method = methodToCall };
            customDelegate.Invoke("Hello world!");
        }

        static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}