namespace Library.Bot.Conditions
{
    public class CalendarCommandCondition : ICondition<CommandRequest>
    {
        public bool IsSatisfied(CommandRequest request)
        {
            if (request.ClientSession.CurrentCommand.Equals("menu") && request.MessageText.Trim().ToLower().Equals("1"))
            {
                return true;
            }
            return false;
        }
    }
}