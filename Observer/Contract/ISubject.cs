namespace Observer.Contract
{
    public interface ISubject
    {
        void Subscribe(ObserverClass observer);
        void Notify();
        void Unsubscribe(ObserverClass observer);
    }
}
