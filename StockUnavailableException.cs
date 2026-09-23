namespace E_Commerce_Order;

public class StockUnavailableException : Exception
{
    public StockUnavailableException (string message) 
        : base (message)
    {
    }
}
