using Adapter.Contracts;

namespace Adapter
{
    /// <summary>
    /// The driver class that demonstrates how to use the adapter pattern
    /// </summary>
    public class Client
    {
        public static void Main(string[] args)
        {
            ITarget target = new Adapter();
            var formattedString = target.GetAllProductNames();
            System.Console.WriteLine(formattedString);
            System.Console.ReadLine();
        }
    }
}
