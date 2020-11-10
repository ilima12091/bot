using Library.Bot.Conditions;
using Library.Bot.Session;
using Library.Bot.Interfaces;

namespace Library.Bot.Handlers
{
    public class MenuCommandHandler : AbstractHandler<CommandRequest>
    {
        public MenuCommandHandler(ICondition<CommandRequest> condition) : base(condition)
        {
        }
        protected override void handleRequest(CommandRequest request, IMessageChannel bot)
        {
            switch(int.Parse(request.MessageText))
            {
                case 1:
                    SessionManager.Instance.SetClientCurrentCommand(request.ClientSession.Id, "calendario");
                    AbstractHandler<CommandRequest> calendarCommandHandler = new CalendarCommandHandler(new CalendarCommandCondition());
                    calendarCommandHandler.Handle(request, bot);
                break;
                case 2:
                    SessionManager.Instance.SetClientCurrentCommand(request.ClientSession.Id, "goleadores");
                    AbstractHandler<CommandRequest> topScorersCommandHandler = new TopScorersCommandHandler(new TopScorersCommandCondition());
                    topScorersCommandHandler.Handle(request, bot);
                break;
                case 3:
                    SessionManager.Instance.SetClientCurrentCommand(request.ClientSession.Id, "equipos");
                break;
                case 4:
                    SessionManager.Instance.SetClientCurrentCommand(request.ClientSession.Id, "estadisticas");
                break;
                default:
                break;
            }
        }
    }
}
