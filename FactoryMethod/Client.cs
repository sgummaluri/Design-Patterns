using FactoryMethod.Entities;

namespace FactoryMethod
{
    /// <summary>
    /// The driver class that demonstrates what FactoryMethod pattern is all about
    /// </summary>
    public class Client
    {
        static public Car GetCar()
        {
            var ferrariCarFactory = new FerrariCarFactory();
            var car = ferrariCarFactory.GetToy();
            return car;
        }

        static void Main(string[] args)
        {
            var car = GetCar();
            System.Console.WriteLine(car.GetType());
            System.Console.ReadLine();
        }
    }
}
