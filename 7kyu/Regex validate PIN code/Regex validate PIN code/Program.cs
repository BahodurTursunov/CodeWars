public class Program
{
    public static bool ValidatePin(string pin)
    {
        if (pin.Length == 4 || pin.Length == 6) return true;
        else return false;
    }
    public static void Main(string[] args)
    {
        string pin = Console.ReadLine();
        Console.WriteLine(ValidatePin(pin));
    }
}