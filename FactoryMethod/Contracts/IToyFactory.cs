using FactoryMethod.Entities;

namespace FactoryMethod.Contracts
{
    public interface IToyFactory
    {
        Car GetToy();
    }
}
