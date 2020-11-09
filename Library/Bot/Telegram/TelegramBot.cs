using System;
using Library.Bot.Conditions;
using Library.Bot.Handlers;
using Library.Bot.Session;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types;

namespace Library.Bot.Telegram
{
    public class TelegramBot : IBot
    {
        private const string TELEBRAM_BOT_TOKEN = "1138036723:AAFQOEIIpQ4NMss4pbDb65arcRfptPQs4Lg";
        private static TelegramBot instance;
        private ITelegramBotClient bot;

        private TelegramBot()
        {
            this.bot = new TelegramBotClient(TELEBRAM_BOT_TOKEN);
        }

        public ITelegramBotClient Client
        {
            get
            {
                return this.bot;
            }
        }

        private User BotInfo
        {
            get
            {
                return this.Client.GetMeAsync().Result;
            }
        }

        public int BotId
        {
            get
            {
                return this.BotInfo.Id;
            }
        }

        public string BotName
        {
            get
            {
                return this.BotInfo.FirstName;
            }
        }

        public static TelegramBot Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TelegramBot();
                }
                return instance;
            }
        }
        public void Start()
        {
            ITelegramBotClient bot = this.Client;
            bot.OnMessage += this.OnMessage;
            bot.StartReceiving();
            Console.WriteLine("Presiona escape para terminar");
            ConsoleKeyInfo cki = Console.ReadKey();
            do
            {
                cki = Console.ReadKey();
            } while (cki.Key != ConsoleKey.Escape);
            bot.StopReceiving();
        }
        private async void OnMessage(object sender, MessageEventArgs messageEventArgs)
        {
            Message message = messageEventArgs.Message;
            Chat ChatInfo = message.Chat;
            string messageText = message.Text.ToLower();
            SessionManager.Instance.StoreClientSession(ChatInfo.Id);
            ClientSession clientSession = SessionManager.Instance.GetClientSession(ChatInfo.Id);
            CommandRequest commandRequest = new CommandRequest(messageText, clientSession);
            
            AbstractHandler<CommandRequest> defaultCommandHandler = new DefaultCommandHandler(new DefaultTrueCondition());
            AbstractHandler<CommandRequest> startCommandHandler = new StartCommandHandler(new StartCommandCondition());
            AbstractHandler<CommandRequest> countryCommandHandler = new CountryCommandHandler(new CountryCommandCondition());
            startCommandHandler.Successor = countryCommandHandler;
            countryCommandHandler.Successor = defaultCommandHandler;
            startCommandHandler.Handle(commandRequest, Instance);
        }
        public async void SendMessage(string text, long clientId)
        {
            ITelegramBotClient client = Instance.Client;
            await client.SendTextMessageAsync(
                chatId: clientId,
                text: text
            );
        }
    }
}