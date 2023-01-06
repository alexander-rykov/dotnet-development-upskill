using ExceptionHandling.Demo.StatusCodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling.Demo.Infrastructure
{
    public class CloudProductStorage : IProductStorage
    {
        public void AddProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetProducts()
        {
            throw new NotImplementedException();
        }
    }
}
