using ErpOrdersDemo.Models;
using ErpOrdersDemo.Services;

namespace ErpOrdersDemo.Tests;

public class OrderServiceTests
{
    [Fact]
    public void Validate_WhenCustomerNameIsMissing_ShouldThrowArgumentException()
    {
        var service = new OrderService();

        var exception = Assert.Throws<ArgumentException>(() =>
            service.Validate(new CreateOrderRequest
            {
                CustomerName = "",
                ProductName = "Teclado",
                Quantity = 2,
                Total = 320m
            }));

        Assert.Contains("CustomerName", exception.Message);
    }

    [Fact]
    public void Validate_WhenQuantityIsZero_ShouldThrowArgumentException()
    {
        var service = new OrderService();

        var exception = Assert.Throws<ArgumentException>(() =>
            service.Validate(new CreateOrderRequest
            {
                CustomerName = "Maria",
                ProductName = "Monitor",
                Quantity = 0,
                Total = 1200m
            }));

        Assert.Contains("Quantity", exception.Message);
    }
}
