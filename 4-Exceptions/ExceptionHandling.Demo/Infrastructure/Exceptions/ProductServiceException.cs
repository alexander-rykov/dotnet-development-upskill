namespace ExceptionHandling.Demo.Infrastructure.Exceptions;

public class ProductsServiceException : Exception
{
	public ProductsServiceException()
		: base()
	{
	}

	public ProductsServiceException(string message)
		: base(message)
	{
	}

	public ProductsServiceException(string message, Exception innerException)
		: base(message, innerException)
	{
	}
}
