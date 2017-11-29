using AbstractFactory.Automobile;
using AbstractFactory.Contracts;

namespace AbstractFactory
{
    class MercedesFactory : IAutoFactory
    {
        public void ProduceEconomicCar()
        {
            MercCClass mercCClass = new MercCClass();
            mercCClass.Run();
        }

        public void ProduceLuxuryCar()
        {
            MercSClass mercSClass = new MercSClass();
            mercSClass.Run();
        }
    }
}
