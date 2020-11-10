using System;
using System.Collections.Generic;

namespace Library.Bot.Session
{
    public class SessionManager
    {
        private static SessionManager instance;
        private SessionManager()
        {
        }
        public static SessionManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SessionManager();
                }
                return instance;
            }
        }
        private Dictionary<string, ClientSession> ClientsState = new Dictionary<string, ClientSession>();
        public ClientSession GetClientSession(string clientId)
        {
            return ClientsState[clientId];
        }
        public void SetClientCurrentCommand(string clientId, string currentCommand, string commandStateId = "", string commandStateValue = "")
        {
            ClientsState[clientId].CurrentCommand = currentCommand;
            ClientsState[clientId].SetState(commandStateId, commandStateValue);
        }
        public void StoreClientSession(string clientId)
        {
            if(!ClientsState.ContainsKey(clientId))
            {
                ClientSession cs = new ClientSession(clientId, "none");
                ClientsState[clientId] = cs;
            }
        }
    }
}