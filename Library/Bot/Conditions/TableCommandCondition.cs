namespace Library.Bot.Conditions
{
    public class TableCommandCondition : ICondition<CommandRequest>
    {
        public bool IsSatisfied(CommandRequest request)
        {
            if (request.ClientSession.CurrentCommand.Equals("menu") && request.MessageText.Trim().ToLower().Equals("4"))
            {
                return true;
            }
            return false;
        }
    }
}