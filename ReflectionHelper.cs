namespace E_Commerce_Order;

public static class ReflectionHelper
{
    public static void InspectObject (object obj)
    {
        Type type = obj.GetType ();
        Console.WriteLine($"Class: {type.Name}");
    }
}
