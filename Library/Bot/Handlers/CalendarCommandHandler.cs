using Library.Bot.Conditions;
using Library.Bot.Session;

namespace Library.Bot.Handlers
{
    public class CalendarCommandHandler : AbstractHandler<CommandRequest>
    {
        public CalendarCommandHandler(ICondition<CommandRequest> condition) : base(condition)
        {
        }
        protected override void handleRequest(CommandRequest request, IBot bot)
        {
            bot.SendMessage("Ingrese el número de la opción que desee:\n1. partidos en \n2. Goleadores", request.ClientSession.Id);
            SessionManager.Instance.SetClientCurrentCommand(request.ClientSession.Id, "menu", "temporada", request.MessageText.Trim());
        }
    }
}
