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
        public void SetClientCurrentCommand(string clientId, string currentCommand)
        {
            ClientsState[clientId].CurrentCommand = currentCommand;
        }
        public void SetState(string userId, string commandStateKey, string commandStateValue)
        {
            ClientsState[userId].SetState(commandStateKey, commandStateValue);
        }
        public void StoreClientSession(string clientId)
        {
            if(!ClientsState.ContainsKey(clientId))
            {
                ClientSession cs = new ClientSession(clientId, "none");
                ClientsState[clientId] = cs;
            }
        }
        public void StoreOptionsIds(string clientId, Dictionary<string, string> options)
        {
            ClientsState[clientId].OptionsId = options;
        }
        public string GetOptionId(string clientId, string option)
        {
            return ClientsState[clientId].OptionsId[option];
        }
    }
}