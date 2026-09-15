namespace ErpOrdersDemo.Models;

public class CreateOrderRequest
{
    public string CustomerName { get; set; } = string.Empty;
    public string ProductName { get; set; } = string.Empty;
    public int Quantity { get; set; }
    public decimal Total { get; set; }
}
