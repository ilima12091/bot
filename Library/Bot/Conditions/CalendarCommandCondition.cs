namespace Library.Bot.Conditions
{
    public class CalendarCommandCondition : ICondition<CommandRequest>
    {
        public bool IsSatisfied(CommandRequest request)
        {
            if (request.ClientSession.CurrentCommand.Equals("calendario"))
            {
                return true;
            }
            return false;
        }
    }
}