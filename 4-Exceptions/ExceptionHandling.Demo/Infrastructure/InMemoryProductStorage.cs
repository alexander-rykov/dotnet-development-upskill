using ExceptionHandling.Demo.StatusCodes;

namespace ExceptionHandling.Demo.Infrastructure
{
    public class InMemoryProductStorage : IProductStorage
    {
        private readonly int _maxSize;
        private readonly Product[] _products;
        private int _currentPosition;

        public InMemoryProductStorage(int maxSize)
        {
            if (maxSize <= 0)
            {
                throw new ArgumentException("Max size of the in-memory product storage can't be negative or equal 0.");
            }

            _maxSize = maxSize;
            _currentPosition = 0;
            _products = new Product[_maxSize];
        }

        public void AddProduct(Product product)
        {
            // No positions checks
            _products[_currentPosition] = product ?? throw new ArgumentNullException(nameof(product));
            _currentPosition++;
        }

        public IEnumerable<Product> GetProducts()
        {
            return _products;
        }
    }
}
