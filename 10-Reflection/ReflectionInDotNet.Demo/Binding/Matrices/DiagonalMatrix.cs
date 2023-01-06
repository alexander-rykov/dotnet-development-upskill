namespace ReflectionInDotNet.Demo.Dynamic.Matrices
{
    public class DiagonalMatrix<T> : SquareMatrix<T>
    {
        private readonly T[] _diagonal;

        public DiagonalMatrix(int size)
            : base(size)
        {
            _diagonal = new T[Size];
        }

        protected override T GetElement(int i, int j)
        {
            return i != j ? default : _diagonal[i];
        }

        protected override void SetElement(int i, int j, T value)
        {
            _diagonal[i] = value;
        }
    }

}
