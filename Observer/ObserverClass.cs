using Observer.Contract;
using System;

namespace Observer
{
    public class ObserverClass : IObserver
    {
        public string Name { get; set; }

        public ObserverClass(string Name)
        {
            this.Name = Name;
        }
        public void Update()
        {
            Console.WriteLine("{0}: There is a new product that has arrived", this.Name);
        }
    }
}
