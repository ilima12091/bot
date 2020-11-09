namespace Library.Bot.Conditions
{
    public class StartCommandCondition : ICondition<CommandRequest>
    {
        public bool IsSatisfied(CommandRequest request)
        {
            if (request.MessageText.Equals("/start"))
            {
                return true;
            }
            return false;
        }
    }
}