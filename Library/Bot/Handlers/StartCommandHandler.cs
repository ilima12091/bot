using Library.Bot.Conditions;
using Library.Bot.Session;

namespace Library.Bot.Handlers
{
    public class StartCommandHandler : AbstractHandler<CommandRequest>
    {
        public StartCommandHandler(ICondition<CommandRequest> condition) : base(condition)
        {
        }
        protected override void handleRequest(CommandRequest request, IBot bot)
        {
            bot.SendMessage("Ingrese el nombre del país", request.ClientSession.Id);
            SessionManager.Instance.SetClientCurrentCommand(request.ClientSession.Id, "pais");
        }
    }
}