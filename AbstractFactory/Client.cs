using System;

namespace AbstractFactory
{
    /// <summary>
    /// This is the Driver Class that demonstrates the nature of Abstract Factory
    /// </summary>
    public class Client
    {
        static void Main(String[] args)
        {
            MercedesFactory mercedesFactory = new MercedesFactory();
            mercedesFactory.ProduceEconomicCar();

            FerrariFactory ferrariFactory = new FerrariFactory();
            ferrariFactory.ProduceLuxuryCar();

            Console.ReadLine();
        }
    }
}
