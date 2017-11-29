using Observer.Contract;
using System.Collections.Generic;

namespace Observer
{
    public class Subject : ISubject
    {
        private List<ObserverClass> Observers;

        private int _int;

        public int InventoryCount
        {
            get
            {
                return _int;
            }
            set
            {
                if (value > _int)
                    Notify();
                _int = value;
            }
        }

        public Subject()
        {
            Observers = new List<ObserverClass>();
        }
        public void Subscribe(ObserverClass observer)
        {
            Observers.Add(observer);
        }

        public void Notify()
        {
            Observers.ForEach(x => x.Update());
        }

        public void Unsubscribe(ObserverClass observer)
        {
            Observers.Remove(observer);
        }
    }
}
