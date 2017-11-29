using SimpleFactory.Entities;

namespace SimpleFactory
{
    public class SimpleFactoryClass
    {
        public static Toy GetToy(string name)
        {
            if (name.Equals("Helicopter"))
                return new HelicopterToy();
            else if (name.Equals("Car"))
                return new CarToy();
            else if (name.Equals("Frog"))
                return new FrogToy();
            else
                return null;
        }
    }
}
