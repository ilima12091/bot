namespace Library.Bot
{
    public interface IBot
    {
        void Start();
        void SendMessage(string text, long clientId);
    }
}