namespace Library.Bot.Conditions
{
    public class TopScorersCommandCondition : ICondition<CommandRequest>
    {
        public bool IsSatisfied(CommandRequest request)
        {
            if (request.ClientSession.CurrentCommand.Equals("goleadores"))
            {
                return true;
            }
            return false;
        }
    }
}