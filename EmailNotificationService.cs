namespace E_Commerce_Order;

public class EmailNotificationService : INotificationService
{
    public async Task NotifyAsync (string message)
    {
        await Task.Delay(1000);
        
    }
}
