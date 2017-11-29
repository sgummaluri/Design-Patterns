using FactoryMethod.Contracts;
using FactoryMethod.Entities;

namespace FactoryMethod
{
    public class FerrariCarFactory : IToyFactory
    {
        public Car GetToy()
        {
            return new FerrariCar();
        }
    }
}
