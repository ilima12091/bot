namespace Library.Bot.Conditions
{
    public class TeamsCommandCondition : ICondition<CommandRequest>
    {
        public bool IsSatisfied(CommandRequest request)
        {
            if (request.ClientSession.CurrentCommand.Equals("menu") && request.MessageText.Trim().ToLower().Equals("3"))
            {
                return true;
            }
            return false;
        }
    }
}