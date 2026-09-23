namespace E_Commerce_Order;

public class Order : IEntity
{
    private static int _idCounter;
    public int Id { get; }
    public CustomerRecord Customer { get; init; }
    public List<OrderItem> Items { get; set; }
    public OrderStatus Status { get; set; }
    public readonly DateTime OrderDate;
    public decimal TotalAmount => Items.Sum(x => x.Price * x.Quantity);

    public Order(CustomerRecord customer)
    {
        Id = ++_idCounter;
        Customer = customer;
        Items = new List<OrderItem>();
        Status = OrderStatus.Pending;
        OrderDate = DateTime.Now;   
    }

    public OrderItem this [int index]
    {
        get
        {
            return Items[index];
        }
        set 
        { 
            Items[index] = value; 
        }
    }
    public static explicit operator decimal (Order order)
    {
        return order.TotalAmount;
    }
    public static implicit operator string (Order order)
    {
        return $"Order ID: {order.Id}, Customer: {order.Customer.FullName}, Total: {order.TotalAmount} AZN";
    }
}
