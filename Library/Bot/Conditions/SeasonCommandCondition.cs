namespace Library.Bot.Conditions
{
    public class SeasonCommandCondition : ICondition<CommandRequest>
    {
        public bool IsSatisfied(CommandRequest request)
        {
            if (request.ClientSession.CurrentCommand.Equals("temporada"))
            {
                return true;
            }
            return false;
        }
    }
}