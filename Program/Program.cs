using System;
using Library.Bot.Telegram;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            TelegramBot telegramBot = TelegramBot.Instance;
            telegramBot.Start();
        }
    }
}
