using ErpOrdersDemo.Models;

namespace ErpOrdersDemo.Services;

public class OrderService
{
    public void Validate(CreateOrderRequest request)
    {
        if (string.IsNullOrWhiteSpace(request.CustomerName))
            throw new ArgumentException("CustomerName is required.");

        if (string.IsNullOrWhiteSpace(request.ProductName))
            throw new ArgumentException("ProductName is required.");

        if (request.Quantity <= 0)
            throw new ArgumentException("Quantity must be greater than zero.");

        if (request.Total <= 0)
            throw new ArgumentException("Total must be greater than zero.");
    }
}
