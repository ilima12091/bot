using Library.Bot.Conditions;
using Library.Bot.Session;
using Library.Bot.Interfaces;

namespace Library.Bot.Handlers
{
    public class ExitCommandHandler : AbstractHandler<CommandRequest>
    {
        public ExitCommandHandler(ICondition<CommandRequest> condition) : base(condition)
        {
        }
        protected override void handleRequest(CommandRequest request, IMessageChannel bot)
        {
            bot.SendMessage("Ha salido exitosamente del proceso de interacción.", request.ClientSession.Id);
            SessionManager.Instance.SetClientCurrentCommand(request.ClientSession.Id, "none");
        }
    }
}