using System;

namespace Sparrow.Reactive.Linq
{
    public class AnyMessenger<T> : Messenger<T, bool>
    {
        public AnyMessenger(ISender<T> sender, Func<T, bool> predictate) : base(predictate)
        {
            Value = true;
            sender.Attach(this);
        }
        
        public override void Receive(T value) { Send(Value || Action(value)); }
    }
}