namespace SimpleFactory
{
    /// <summary>
    /// The Driver class to invoke the functionality of a SimpleFactory pattern.
    /// Pass any of "Helicopter", "Car", "Frog" as parameter to GetToy() method to get the corresponding type of object.
    /// Further, the factory can be extended to include any number of types and create corresponding types of objects.
    /// </summary>
    public class Client
    {
        static void Main(string[] args)
        {
            var toy = SimpleFactoryClass.GetToy("Helicopter");
            // The below statement is to check what type of object is created.
            // Try varying the parameter that is passed to create different objects
            System.Console.WriteLine(toy.GetType());
            System.Console.ReadLine();
        }
    }
}
