namespace Library.Bot.Conditions
{
    public interface ICondition<T>
    {
        bool IsSatisfied(T request);
    }
}