namespace E_Commerce_Order;

public class OrderProcessor <T> : IOrderService<T> where T : Order, IEntity
{
    private readonly INotificationService _notificationService;
    public OrderProcessor(INotificationService notificationService)
    {
        _notificationService = notificationService;
    }
    List<T> Orders = new List<T>();
    private IEnumerable<object> _orders;

    public async Task ProcessOrdersConcurrentlyAsync()
    {
        await Parallel.ForEachAsync(
            _orders,
            async (order, cancellationToken) =>
            {
                Console.WriteLine($"Processing Order: {order.Id}");

                await Task.Delay(1000);

                Console.WriteLine($"Order {order.Id} completed.");
            });
    }
}
