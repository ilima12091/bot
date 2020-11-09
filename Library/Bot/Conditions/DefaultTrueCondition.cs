using Library.Bot.Session;

namespace Library.Bot.Conditions
{
    public class DefaultTrueCondition : ICondition<CommandRequest>
    {
        public bool IsSatisfied(CommandRequest request)
        {
            return true;
        }
    }
}