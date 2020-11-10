namespace Library.Bot.Conditions
{
    public class TeamsCommandCondition : ICondition<CommandRequest>
    {
        public bool IsSatisfied(CommandRequest request)
        {
            if (request.ClientSession.CurrentCommand.Equals("equipos"))
            {
                return true;
            }
            return false;
        }
    }
}