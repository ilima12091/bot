namespace Library.Bot.Conditions
{
    public class TopScorersCommandCondition : ICondition<CommandRequest>
    {
        public bool IsSatisfied(CommandRequest request)
        {
            if (request.ClientSession.CurrentCommand.Equals("menu") && request.MessageText.Trim().ToLower().Equals("2"))
            {
                return true;
            }
            return false;
        }
    }
}