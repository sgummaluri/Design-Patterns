using FactoryMethod.Contracts;
using FactoryMethod.Entities;

namespace FactoryMethod
{
    public class MercedesCarFactory : IToyFactory
    {
        public Car GetToy()
        {
            return new MercedesCar();
        }
    }
}
