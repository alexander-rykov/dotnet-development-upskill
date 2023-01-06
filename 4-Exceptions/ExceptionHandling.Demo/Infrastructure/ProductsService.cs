using ExceptionHandling.Demo.Infrastructure.Exceptions;

namespace ExceptionHandling.Demo.StatusCodes
{
    public class ProductsService
    {
        private readonly IProductStorage _productStorage;

        public ProductsService(IProductStorage productStorage)
        {
            _productStorage = productStorage ?? throw new ArgumentNullException(nameof(productStorage));
        }

        public void AddProduct(Product product)
        {
            try
            {
                var newId = _productStorage.GetProducts().LastOrDefault()?.Id + 1 ?? 1;
                product.Id = newId;

                _productStorage.AddProduct(product);
            }
            catch (ArgumentNullException)
            {
                throw new ProductsServiceException("Product can't be null.");
            }
            catch (Exception ex)
            {
                // Changing the stack trace
                throw ex;
            }
        }

        public Product? GetProductByName(string name)
        {
            ValidateProductName(name);

            foreach (var product in _productStorage.GetProducts())
            {
                if (product.Name.Equals(name))
                {
                    return product;
                }
            }

            return null;
        }

        public Product GetByNameOrThrow(string name)
        {
            ValidateProductName(name);

            foreach (var product in _productStorage.GetProducts())
            {
                if (product.Name.Equals(name))
                {
                    return product;
                }
            }

            throw new ProductsServiceException($"Could not find a product with the name '{name}'.");
        }

        private static void ValidateProductName(string productName)
        {
            if (string.IsNullOrWhiteSpace(productName))
            {
                throw new ArgumentNullException(nameof(productName));
            }
        }
    }
}
