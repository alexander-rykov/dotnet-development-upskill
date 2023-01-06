using System;

namespace ReflectionInDotNet.Demo.Dynamic.Matrices
{
    public abstract class Matrix<T>
    {
        public Matrix(int size)
        {
            if (size < 0)
            {
                throw new ArgumentException("Matrix size can't be negative.");
            }

            Size = size;
        }

        public int Size { get; }

        public T this[int i, int j]
        {
            get
            {
                return GetElement(i, j);
            }
            set
            {
                if (!Equals(GetElement(i, j), value))
                {
                    SetElement(i, j, value);
                }
            }
        }

        protected abstract void SetElement(int i, int j, T value);

        protected abstract T GetElement(int i, int j);
    }
}