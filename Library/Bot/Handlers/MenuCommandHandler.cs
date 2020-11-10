using Library.Bot.Conditions;
using Library.Bot.Session;

namespace Library.Bot.Handlers
{
    public class MenuCommandHandler : AbstractHandler<CommandRequest>
    {
        public MenuCommandHandler(ICondition<CommandRequest> condition) : base(condition)
        {
        }
        protected override void handleRequest(CommandRequest request, IBot bot)
        {
            switch(int.Parse(request.MessageText))
            {
                case 1:
                    SessionManager.Instance.SetClientCurrentCommand(request.ClientSession.Id, "calendario");
                break;
                case 2:
                    SessionManager.Instance.SetClientCurrentCommand(request.ClientSession.Id, "goleadores");
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
