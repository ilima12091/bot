using Library.Bot.Conditions;
using Library.Bot.Session;
using Library.Bot.Interfaces;

namespace Library.Bot.Handlers
{
    public class SeasonCommandHandler : AbstractHandler<CommandRequest>
    {
        public SeasonCommandHandler(ICondition<CommandRequest> condition) : base(condition)
        {
        }
        protected override void handleRequest(CommandRequest request, IMessageChannel bot)
        {
            bot.SendMessage("Ingrese el número que corresponda a la liga que le interesa:\n1. Apertura\n2. Clausura\n3. Apertura - segunda división", request.ClientSession.Id);
            SessionManager.Instance.SetClientCurrentCommand(request.ClientSession.Id, "liga", "temporada", request.MessageText.Trim());
        }
    }
}
