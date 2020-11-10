using System;

namespace Library.Bot.BotExceptions
{
    public class InvalidSeasonException : Exception
    {
        public InvalidSeasonException(string message) : base(message)
        {
            
        }
    }
}