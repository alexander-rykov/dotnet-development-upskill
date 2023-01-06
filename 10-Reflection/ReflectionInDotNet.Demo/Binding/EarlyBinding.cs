using ReflectionInDotNet.Demo.Dynamic.Matrices;
using System;

namespace ReflectionInDotNet.Demo.Binding
{
    internal static class EarlyBinding
    {
        public static void Print<T>(SquareMatrix<T> matrix)
        { 
            Console.WriteLine("This is a square matrix");
        }

        public static void Print<T>(DiagonalMatrix<T> matrix)
        {
            Console.WriteLine("This is a diagonal matrix");
        }

        public static void Print<T>(Matrix<T> matrix)
        {
            Console.WriteLine("This is a matrix");
        }
    }
}
