namespace Library.Bot.Conditions
{
    public class StartCommandCondition : ICondition<CommandRequest>
    {
        public bool IsSatisfied(CommandRequest request)
        {
            if (request.MessageText.Equals("/start") && request.ClientSession.CurrentCommand.Equals("none"))
            {
                return true;
            }
            return false;
        }
    }
}