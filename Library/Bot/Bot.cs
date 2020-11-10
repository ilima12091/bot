using System;
using Library.Bot.Conditions;
using Library.Bot.Handlers;
using Library.Bot.Interfaces;

namespace Library.Bot
{
    public class Bot : IObserver
    {
        private static Bot instance;
        private IMessageChannel channel;
        private Bot()
        {
        }
        public static Bot Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Bot();
                }
                return instance;
            }
        }
        public void Start(IMessageChannel channel)
        {
            this.channel = channel;
            channel.Subscribe(this);
        }
        public void Update(CommandRequest commandRequest)
        {
            AbstractHandler<CommandRequest> defaultCommandHandler = new DefaultCommandHandler(new DefaultTrueCondition());
            AbstractHandler<CommandRequest> startCommandHandler = new StartCommandHandler(new StartCommandCondition());
            AbstractHandler<CommandRequest> countryCommandHandler = new CountryCommandHandler(new CountryCommandCondition());
            AbstractHandler<CommandRequest> seasonCommandHandler = new SeasonCommandHandler(new SeasonCommandCondition());
            AbstractHandler<CommandRequest> leagueCommandHandler = new LeagueCommandHandler(new LeagueCommandCondition());
            AbstractHandler<CommandRequest> menuCommandHandler = new MenuCommandHandler(new MenuCommandCondition());

            startCommandHandler.Successor = countryCommandHandler;
            countryCommandHandler.Successor = seasonCommandHandler;
            seasonCommandHandler.Successor = leagueCommandHandler;
            leagueCommandHandler.Successor = menuCommandHandler;
            menuCommandHandler.Successor = defaultCommandHandler;

            startCommandHandler.Handle(commandRequest, this.channel);
        }
    }
}