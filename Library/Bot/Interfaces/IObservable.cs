namespace Library.Bot.Interfaces
{
    public interface IObservable
    {
        void Subscribe(IObserver observer);
        void Unsubscribe(IObserver observer);
        void NotifyObservers(CommandRequest commandRequest);
    }
}