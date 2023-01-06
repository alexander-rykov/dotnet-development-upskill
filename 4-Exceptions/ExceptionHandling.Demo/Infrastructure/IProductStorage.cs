namespace ExceptionHandling.Demo.StatusCodes
{
    public interface IProductStorage
    {
        public void AddProduct(Product product);

        public IEnumerable<Product> GetProducts();
    }
}