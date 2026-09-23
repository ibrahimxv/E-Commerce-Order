namespace E_Commerce_Order;

public class OrderItem
{
    public int ProductId { get; set; }
    public string ProductName { get; set; } = null!;
    public decimal Price { get; set; }
    public decimal Quantity { get; set; }

    public OrderItem DeepCopy()
    {
        return new OrderItem
        {
            ProductId = ProductId,
            ProductName = ProductName,
            Price = Price,
            Quantity = Quantity
        };
    }
}
