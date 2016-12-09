using System;

namespace Sparrow.Reactive.Linq
{
    public class AnyMessenger<T> : Messenger<T, bool>
    {
        public AnyMessenger(ISender<T> sender, Func<T, bool> predictate) : base(null)
        {
            Predicate = predictate;
            Value = true;
            sender.Attach(this);
        }

        private Func<T, bool> Predicate;
        
        public override void Receive(T value) { Send(Value || Predicate(value)); }
    }
}