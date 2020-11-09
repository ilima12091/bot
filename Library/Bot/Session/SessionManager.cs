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
        private Dictionary<long, ClientSession> ClientsState = new Dictionary<long, ClientSession>();
        public ClientSession GetClientSession(long clientId)
        {
            return ClientsState[clientId];
        }
        public void SetClientCurrentCommand(long clientId, string currentCommand, string commandStateId = "", string commandStateValue = "")
        {
            ClientsState[clientId].CurrentCommand = currentCommand;
            ClientsState[clientId].SetState(commandStateId, commandStateValue);
        }
        public void StoreClientSession(long clientId)
        {
            if(!ClientsState.ContainsKey(clientId))
            {
                ClientSession cs = new ClientSession(clientId, "none");
                ClientsState[clientId] = cs;
            }
        }
    }
}