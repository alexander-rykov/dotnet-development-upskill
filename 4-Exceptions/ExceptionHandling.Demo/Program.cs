using ExceptionHandling.Demo.Infrastructure;
using ExceptionHandling.Demo.Infrastructure.Exceptions;
using ExceptionHandling.Demo.StatusCodes;

namespace ExceptionHandling.Demo
{
    internal class Program
    {
        public static void Main()
        {

            var products = new Product[]
            {
                new Product
                {
                    Id = 1,
                    Name = "Fresh Water",
                    Description = "It's really fresh."
                },

                new Product
                {
                    Id = 2,
                    Name = "Freshest Bread",
                    Description = "Even fresher than fresh water!"
                }
            };

            #region Working with Status Codes

            Console.Write("Enter the product's name: ");
            var productName = Console.ReadLine();

            StatusCode result = FindProductByName(products, productName);
            switch (result)
            {
                case StatusCode.Success:
                    Console.WriteLine($"Successfuly found the '{productName}' product!");
                    break;
                case StatusCode.NullArgument:
                    Console.WriteLine($"One of the arguments (array of products, product name) is null or the '{productName}' is empty or a whitespace.");
                    break;
                case StatusCode.NotFound:
                default:
                    Console.WriteLine($"Product '{productName}' does not exist!");
                    break;
            }

            #endregion

            #region Working with Exceptions

            //var productStorage = SetupProductStorage(products, maxSize: products.Length);
            //var productsService = new ProductsService(productStorage);

            //Console.Write("Enter the new product's name: ");
            //var newProductName = Console.ReadLine();

            //Console.Write("Enter the new product's description: ");
            //var newProductDescription = Console.ReadLine();

            //AddProduct(productsService, newProductName, newProductDescription);

            #endregion
        }

        #region Status Codes
        private enum StatusCode
        {
            Success,
            NullArgument,
            NotFound
        }

        private static StatusCode FindProductByName(Product[] products, string name)
        {
            if (products == null)
            {
                return StatusCode.NullArgument;
            }

            if (string.IsNullOrWhiteSpace(name))
            {
                // Doens't specify which argument is null
                return StatusCode.NullArgument;
            }

            foreach (var product in products)
            {
                if (product.Name.Equals(name))
                {
                    // Doesn't return any product - only status code
                    Console.WriteLine(product);
                    return StatusCode.Success;
                }
            }

            return StatusCode.NotFound;
        }

        #endregion Status Codes

        #region Exceptions

        private static IProductStorage SetupProductStorage(Product[] products, int maxSize)
        {
            var storage = new InMemoryProductStorage(maxSize);
            foreach (var product in products)
            {
                storage.AddProduct(product);
            }

            return storage;
        }

        public static void AddProduct(ProductsService productsService, string? name, string? description)
        {
            try
            {
                var product = new Product()
                {
                    Name = name,    
                    Description = description
                };

                productsService.AddProduct(product);
            }
            catch (ProductsServiceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occured: {ex.Message}\n Stack trace: {ex.StackTrace}.");
            }
        }

        #endregion
    }
}