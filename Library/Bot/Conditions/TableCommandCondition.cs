namespace Library.Bot.Conditions
{
    public class TableCommandCondition : ICondition<CommandRequest>
    {
        public bool IsSatisfied(CommandRequest request)
        {
            if (request.ClientSession.CurrentCommand.Equals("tabla"))
            {
                return true;
            }
            return false;
        }
    }
}