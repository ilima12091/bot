using Library.Bot.Conditions;
using Library.Bot.Session;


namespace Library.Bot.Handlers
{
    public class CountryCommandHandler : AbstractHandler<CommandRequest>
    {
        public CountryCommandHandler(ICondition<CommandRequest> condition) : base(condition)
        {
        }
        protected override void handleRequest(CommandRequest request, IBot bot)
        {
            bot.SendMessage("Ingrese la temporada que le interesa", request.ClientSession.Id);
        }
    }
}