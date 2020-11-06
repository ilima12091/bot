using Library.Bot.Conditions;
using Library.Bot.Session;

namespace Library.Bot.Handlers
{
    public class DefaultCommandHandler : AbstractHandler<ClientSession>
    {
        public DefaultCommandHandler(ICondition<ClientSession> condition) : base(condition)
        {
        }
        protected override void handleRequest(ClientSession request)
        {
            
        }
    }
}