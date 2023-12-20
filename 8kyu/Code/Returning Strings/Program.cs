namespace Returning_Strings
{
    internal class Program
    {
        public static string Greet(string name)
        {
            return ($"Hello, {name} how are you doing today?");
        }

        static void Main(string[] args)
        {
            var res =  Greet("Bakha");
            Console.WriteLine(res);
        }
    }
}

