namespace Library.Bot.Conditions
{
    public class ExitCommandCondition : ICondition<CommandRequest>
    {
        public bool IsSatisfied(CommandRequest request)
        {
            if (request.MessageText.Equals("/exit") && !request.ClientSession.CurrentCommand.Equals("none"))
            {
                return true;
            }
            return false;
        }
    }
}