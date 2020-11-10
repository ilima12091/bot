using Library.Bot.Conditions;
using Library.Bot.Session;
using Library.Bot.Interfaces;

namespace Library.Bot.Handlers
{
    public class TableCommandHandler : AbstractHandler<CommandRequest>
    {
        public TableCommandHandler(ICondition<CommandRequest> condition) : base(condition)
        {
        }
        protected override void handleRequest(CommandRequest request, IMessageChannel bot)
        {
            bot.SendMessage("Tabla de la liga <nombreLiga>:\n1 - Barcelona\n2 - Real Madrid\n3 - Atlético de Madrid\n4 - Valencia", request.ClientSession.Id);
            SessionManager.Instance.SetClientCurrentCommand(request.ClientSession.Id, "equipo");
        }
    }
}