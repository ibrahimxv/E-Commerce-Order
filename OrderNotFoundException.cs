namespace E_Commerce_Order;

public class OrderNotFoundException : Exception
{
    public OrderNotFoundException (string message) 
        :base (message)
    {
    }
}
