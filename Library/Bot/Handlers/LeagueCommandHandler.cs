using Library.Bot.Conditions;
using Library.Bot.Session;

namespace Library.Bot.Handlers
{
    public class LeagueCommandHandler : AbstractHandler<CommandRequest>
    {
        public LeagueCommandHandler(ICondition<CommandRequest> condition) : base(condition)
        {
        }
        protected override void handleRequest(CommandRequest request, IBot bot)
        {
            bot.SendMessage("Ingrese el número de la opción que desee:\n1. Calendario\n2. Goleadores\n3. Equipos\n4. Estadísticas", request.ClientSession.Id);
            SessionManager.Instance.SetClientCurrentCommand(request.ClientSession.Id, "menu", "idLiga", request.MessageText.Trim());
        }
    }
}
