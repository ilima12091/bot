using System;
using Library.Bot.Conditions;
using Library.Bot.Session;
using Library.Bot.Interfaces;
using Library.Bot.BotExceptions;

namespace Library.Bot.Handlers
{
    public class SeasonCommandHandler : AbstractHandler<CommandRequest>
    {
        public SeasonCommandHandler(ICondition<CommandRequest> condition) : base(condition)
        {
        }
        protected override void handleRequest(CommandRequest request, IMessageChannel bot)
        {
            try {
                if (int.Parse(request.MessageText.Trim()) != 2020)
                {
                    throw new InvalidSeasonException("La temporada ingresada no es válida");
                }
                bot.SendMessage("Ingrese el número que corresponda a la liga que le interesa:\n1. Apertura\n2. Clausura\n3. Apertura - segunda división", request.ClientSession.Id);
                SessionManager.Instance.SetClientCurrentCommand(request.ClientSession.Id, "liga");
                SessionManager.Instance.SetState(request.ClientSession.Id, "temporada", request.MessageText.Trim());
            } 
            catch (InvalidSeasonException ex)
            {
                bot.SendMessage(ex.Message, request.ClientSession.Id);    
            }
            catch (FormatException ex)
            {
                bot.SendMessage("Debe ingresar un número, no letras.", request.ClientSession.Id);    
            }
        }
    }
}
