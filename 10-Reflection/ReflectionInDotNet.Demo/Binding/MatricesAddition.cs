using ReflectionInDotNet.Demo.Dynamic.Matrices;
using System;

namespace ReflectionInDotNet.Demo.Dynamic
{
    public static class MatricesAddition
    {
        public static Matrix<T> Add<T>(this Matrix<T> lhs, Matrix<T> rhs)
        {
            if (lhs is null)
            {
                throw new ArgumentNullException(nameof(lhs), "Left matrix can't be null.");
            }

            if (rhs is null)
            {
                throw new ArgumentNullException(nameof(rhs), "Right matrix can't be null.");
            }

            if (lhs.Size != rhs.Size)
            {
                throw new ArgumentException("Matrices must have equal sizes.");
            }

            return AddImplementation<T>((dynamic)lhs, (dynamic)rhs);
        }

        private static SquareMatrix<T> AddImplementation<T>(SquareMatrix<T> lhs, SquareMatrix<T> rhs)
        {
            SquareMatrix<T> result = new SquareMatrix<T>(lhs.Size);
            for (int i = 0; i < lhs.Size; i++)
            {
                for (int j = 0; j < lhs.Size; j++)
                {
                    result[i, j] = (dynamic)lhs[i, j] + rhs[i, j];
                }
            }

            return result;
        }

        private static SquareMatrix<T> AddImplementation<T>(SquareMatrix<T> lhs, DiagonalMatrix<T> rhs)
        {
            SquareMatrix<T> result = new SquareMatrix<T>(lhs.Size);
            for (int i = 0; i < lhs.Size; i++)
            {
                for (int j = 0; j < lhs.Size; j++)
                {
                    result[i, j] = (dynamic)lhs[i, j] + rhs[i, j];
                }
            }

            return result;
        }

        private static SquareMatrix<T> AddImplementation<T>(DiagonalMatrix<T> lhs, SquareMatrix<T> rhs)
        {
            return AddImplementation(rhs, lhs);
        }

        private static DiagonalMatrix<T> AddImplementation<T>(DiagonalMatrix<T> lhs, DiagonalMatrix<T> rhs)
        {
            DiagonalMatrix<T> result = new DiagonalMatrix<T>(lhs.Size);

            for (int i = 0; i < lhs.Size; i++)
            {
                result[i, i] = (dynamic)lhs[i, i] + rhs[i, i];
            }

            return result;
        }
    }
}
