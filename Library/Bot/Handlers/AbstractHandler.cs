using Library.Bot.Conditions;
using Library.Bot.Interfaces;

namespace Library.Bot.Handlers
{
    public abstract class AbstractHandler<T>
    {
        private ICondition<T> condition;
        public AbstractHandler<T> Successor { get; set; }
        protected AbstractHandler(ICondition<T> condition)
        {
            this.condition = condition;
        }
        public virtual void Handle(T request, IMessageChannel bot)
        {
            if (this.condition.IsSatisfied(request))
            {
                this.handleRequest(request, bot);
            }
            else
            {
                if (this.Successor != null)
                {
                    this.Successor.Handle(request, bot);
                }
            }
        }
        protected abstract void handleRequest(T request, IMessageChannel bot);
    }
}