namespace E_Commerce_Order;

public static class StringExtensions
{
    public static string ToCapitalize (this string text)
    {
        return char.ToUpper(text[0]) + text.Substring(1).ToLower();
    }
}
