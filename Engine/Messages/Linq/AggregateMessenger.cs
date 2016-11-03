using System;

namespace Sparrow.Messages.Linq
{
    public class AggregateMessenger<T> : Messenger<T, T>
    {
        public AggregateMessenger(ISender<T> sender, Func<T, T, T> func) : base(null)
        {
            this.func = func;
            sender.Attach(this);
        }

        private Func<T, T, T> func;
        
        public override void Receive(T value) { Send(func(Value, value)); }
    }
}