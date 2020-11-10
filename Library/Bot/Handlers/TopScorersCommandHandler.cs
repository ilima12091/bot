using Library.Bot.Conditions;
using Library.Bot.Session;
using Library.Bot.Interfaces;

namespace Library.Bot.Handlers
{
    public class TopScorersCommandHandler : AbstractHandler<CommandRequest>
    {
        public TopScorersCommandHandler(ICondition<CommandRequest> condition) : base(condition)
        {
        }
        protected override void handleRequest(CommandRequest request, IMessageChannel bot)
        {
            bot.SendMessage("Goleadores de la liga <nombreLiga>:\n- Luis Suárez\n- Edinson Cavani", request.ClientSession.Id);
            SessionManager.Instance.SetClientCurrentCommand(request.ClientSession.Id, "none");
        }
    }
}
