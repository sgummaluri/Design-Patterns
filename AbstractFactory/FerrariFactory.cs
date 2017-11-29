using AbstractFactory.Automobile;
using AbstractFactory.Contracts;

namespace AbstractFactory
{
    public class FerrariFactory : IAutoFactory
    {
        public void ProduceEconomicCar()
        {
            FerrariF40 ferrariF40 = new FerrariF40();
            ferrariF40.Run();
        }

        public void ProduceLuxuryCar()
        {
            Ferrari250 ferrari250 = new Ferrari250();
            ferrari250.Run();
        }
    }
}
