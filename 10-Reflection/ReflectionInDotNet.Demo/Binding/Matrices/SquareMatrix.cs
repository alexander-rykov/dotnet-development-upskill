namespace ReflectionInDotNet.Demo.Dynamic.Matrices
{
    public class SquareMatrix<T> : Matrix<T>
    {
        private readonly T[,] _matrix;

        public SquareMatrix(int size)
            : base(size)
        {
            _matrix = new T[Size, Size];
        }

        protected override void SetElement(int i, int j, T value)
        {
            _matrix[i, j] = value;
        }

        protected override T GetElement(int i, int j)
        {
            return _matrix[i, j];
        }
    }
}
