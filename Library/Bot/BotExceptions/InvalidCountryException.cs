using System;

namespace Library.Bot.BotExceptions
{
    public class InvalidCountryException : Exception
    {
        public InvalidCountryException(string message) : base(message)
        {
            
        }
    }
}