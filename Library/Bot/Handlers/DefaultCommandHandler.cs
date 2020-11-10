using Library.Bot.Conditions;
using Library.Bot.Interfaces;

namespace Library.Bot.Handlers
{
    public class DefaultCommandHandler : AbstractHandler<CommandRequest>
    {
        public DefaultCommandHandler(ICondition<CommandRequest> condition) : base(condition)
        {
        }
        protected override void handleRequest(CommandRequest request, IMessageChannel bot)
        {
            bot.SendMessage("Ingrese el comando /start para iniciar la interacción con el bot", request.ClientSession.Id);
        }
    }
}