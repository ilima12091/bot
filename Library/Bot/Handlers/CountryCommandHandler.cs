using Library.Bot.Conditions;
using Library.Bot.Session;
using Library.Bot.Interfaces;
using Library.Bot.BotExceptions;

namespace Library.Bot.Handlers
{
    public class CountryCommandHandler : AbstractHandler<CommandRequest>
    {
        public CountryCommandHandler(ICondition<CommandRequest> condition) : base(condition)
        {
        }
        protected override void handleRequest(CommandRequest request, IMessageChannel bot)
        {
            try {
                if (request.MessageText.Trim().ToLower() != "uruguay")
                {
                    throw new InvalidCountryException("El país \"" + request.MessageText + "\" no está dentro de la lista de paises posibles, por favor ingrese uno válido.");
                }
                bot.SendMessage("Ingrese la temporada que le interesa", request.ClientSession.Id);
                SessionManager.Instance.SetClientCurrentCommand(request.ClientSession.Id, "temporada");
                SessionManager.Instance.SetState(request.ClientSession.Id, "pais", request.MessageText.Trim());
            } 
            catch (InvalidCountryException ex)
            {
                bot.SendMessage(ex.Message, request.ClientSession.Id);    
            }
        }
    }
}