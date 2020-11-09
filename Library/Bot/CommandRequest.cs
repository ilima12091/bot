using Library.Bot.Session;

namespace Library.Bot
{
    public class CommandRequest
    {
        public string MessageText { get; }
        public ClientSession ClientSession { get; }
        public CommandRequest(string messageText, ClientSession clientSession)
        {
            this.MessageText = messageText;
            this.ClientSession = clientSession;
        }
    }
}