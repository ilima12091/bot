namespace Library.Bot.Conditions
{
    public class LeagueCommandCondition : ICondition<CommandRequest>
    {
        public bool IsSatisfied(CommandRequest request)
        {
            if (request.ClientSession.CurrentCommand.Equals("liga"))
            {
                return true;
            }
            return false;
        }
    }
}