using System;
using Library.Bot.Interfaces;
using Library.Bot.Telegram;
using Library.Bot;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            IMessageChannel telegramChannel = TelegramBot.Instance;
            Bot bot = Bot.Instance;
            bot.Start(telegramChannel);
        }
    }
}
