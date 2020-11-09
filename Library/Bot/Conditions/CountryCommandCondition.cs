namespace Library.Bot.Conditions
{
    public class CountryCommandCondition : ICondition<CommandRequest>
    {
        public bool IsSatisfied(CommandRequest request)
        {
            if (request.ClientSession.CurrentCommand.Equals("pais"))
            {
                return true;
            }
            return false;
        }
    }
}