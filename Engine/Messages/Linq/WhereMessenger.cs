using System;

namespace Sparrow.Messages.Linq
{
    public class WhereMessenger<T> : Messenger<T, T>
    {
        public WhereMessenger(ISender<T> sender, Func<T, bool> predictate) : base(null)
        {
            Selector = predictate;
            sender.Attach(this);
        }

        private Func<T, bool> Selector;
        
        public override void Receive(T value) { Send(value); }
        
        public override void Send(T value)
        {
            if (!Selector(value)) return;
            Value = value;
            foreach(var receiver in Receivers)
                receiver(Value);
        }
    }
}