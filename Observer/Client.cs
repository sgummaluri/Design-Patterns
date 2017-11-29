using System;

namespace Observer
{
    /// <summary>
    /// The driver class that drives the sample Observer pattern
    /// This is similar to a pub-sub technique. You can subscribe on a subject and can unsubscribe from it.
    /// </summary>
    public class Client
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject();

            ObserverClass observer1 = new ObserverClass("Observer1");
            subject.Subscribe(observer1);
            subject.Subscribe(new ObserverClass("Observer2"));
            subject.InventoryCount++;
            subject.Unsubscribe(observer1);
            subject.Subscribe(new ObserverClass("Observer3"));
            subject.InventoryCount++;
            Console.ReadLine();
        }
    }
}
