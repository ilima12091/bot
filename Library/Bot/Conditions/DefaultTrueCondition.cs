using Library.Bot.Session;

namespace Library.Bot.Conditions
{
    public class DefaultTrueCondition : ICondition<ClientSession>
    {
        public bool IsSatisfied(ClientSession request)
        {
            return true;
        }
    }
}