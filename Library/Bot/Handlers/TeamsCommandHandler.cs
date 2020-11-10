using Library.Bot.Conditions;
using Library.Bot.Session;
using Library.Bot.Interfaces;

namespace Library.Bot.Handlers
{
    public class TeamsCommandHandler : AbstractHandler<CommandRequest>
    {
        public TeamsCommandHandler(ICondition<CommandRequest> condition) : base(condition)
        {
        }
        protected override void handleRequest(CommandRequest request, IMessageChannel bot)
        {
            bot.SendMessage("Seleccione uno de los equipos que forman parte de la liga <nombreLiga> para obtener más información:\n1. Nacional\n2. Peñarol\n3. Defensor", request.ClientSession.Id);
            SessionManager.Instance.SetClientCurrentCommand(request.ClientSession.Id, "none");
        }
    }
}