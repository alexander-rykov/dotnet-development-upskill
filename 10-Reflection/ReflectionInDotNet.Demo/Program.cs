using ReflectionInDotNet.Demo.Attributes;
using ReflectionInDotNet.Demo.Binding;
using ReflectionInDotNet.Demo.Dynamic;
using ReflectionInDotNet.Demo.Dynamic.Matrices;
using System;
using System.Linq;
using System.Reflection;

namespace ReflectionInDotNet.Demo
{
    internal class Program
    {
        public static void Main()
        {
            #region Working with Type

            //string text = "Hello world!";

            //var type = typeof(string); // Compile time variable
            //type = text.GetType(); // Runtime variable

            //type = Type.GetType("System.String");

            //var fields = type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            //foreach (var field in fields)
            //{
            //    Console.WriteLine(field.Name);
            //}

            //fields[0].SetValue(text, 2); // Set the private (!) field "_stringLength" to 2.
            //Console.WriteLine(text);

            #endregion

            #region Attributes by themselves don't do anything

            //var employee = new Employee();

            //employee.FirstName = "ThisStringContainsMoreThanTwentyCharacters";
            //employee.Age = -1;

            #endregion

            #region Validate employee according to attributes

            //var employeeValidator = new EmployeeValidator();
            //if (!employeeValidator.ValidateEmployee(employee))
            //{
            //    foreach (var error in employeeValidator.Errors)
            //    {
            //        Console.WriteLine(error);
            //    }
            //}

            #endregion

            #region Early Binding

            //var squareMatrix = new SquareMatrix<int>(5);
            //var symmetricMatrix = new DiagonalMatrix<int>(5);

            //EarlyBinding.Print(squareMatrix);
            //EarlyBinding.Print(symmetricMatrix);
            //EarlyBinding.Print((Matrix<int>)symmetricMatrix);

            #endregion

            #region Dynamic Parameters

            //squareMatrix.Add(symmetricMatrix);

            //symmetricMatrix.Add(squareMatrix);

            //squareMatrix.Add(squareMatrix);

            //symmetricMatrix.Add(symmetricMatrix);

            #endregion

            #region Create Types at Runtime

            //Employee runtimeEmployee = (Employee)Activator.CreateInstance(typeof(Employee));
            //Matrix<int> runtimeMatrix = (Matrix<int>)Activator.CreateInstance(typeof(SquareMatrix<int>), 5);
            //Console.WriteLine(runtimeMatrix.Size);

            //var toStringMethodInfo = typeof(int).GetMethod("ToString", BindingFlags.Public | BindingFlags.Instance, Array.Empty<Type>());
            //var result = toStringMethodInfo.Invoke(5, null);
            //Console.WriteLine(result);

            #endregion
        }
    }
}
