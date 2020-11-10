namespace Library.Bot.Conditions
{
    public class MenuCommandCondition : ICondition<CommandRequest>
    {
        public bool IsSatisfied(CommandRequest request)
        {
            if (request.ClientSession.CurrentCommand.Equals("menu"))
            {
                return true;
            }
            return false;
        }
    }
}