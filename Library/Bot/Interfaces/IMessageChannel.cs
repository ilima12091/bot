namespace Library.Bot.Interfaces
{
    public interface IMessageChannel : IObservable
    {
        void SendMessage(string clientId, string message);
    }
}