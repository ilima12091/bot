using Library.Bot.Conditions;
using Library.Bot.Session;
using Library.Bot.Interfaces;

namespace Library.Bot.Handlers
{
    public class CalendarCommandHandler : AbstractHandler<CommandRequest>
    {
        public CalendarCommandHandler(ICondition<CommandRequest> condition) : base(condition)
        {
        }
        protected override void handleRequest(CommandRequest request, IMessageChannel bot)
        {
            bot.SendMessage("Calendario para la liga <nombreLiga>:\n- partido\n- partido", request.ClientSession.Id);
            SessionManager.Instance.SetClientCurrentCommand(request.ClientSession.Id, "none");
        }
    }
}
