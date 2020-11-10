using System.Collections.Generic;

namespace Library.Bot.Session
{
    public class ClientSession
    {
        public string Id { get; }
        public string CurrentCommand { get; set; }
        public Dictionary<string, string> CommandState { get; set; }
        public void SetState(string commandStateId, string commandStateValue)
        {
            this.CommandState[commandStateId] = commandStateValue;
        }
        public ClientSession(string id, string CurrentCommand)
        {
            this.Id = id;
            this.CurrentCommand = CurrentCommand;
            this.CommandState = new Dictionary<string, string>();
        }
    }
}