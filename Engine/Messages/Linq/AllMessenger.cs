using System;

namespace Sparrow.Messages.Linq
{
    public class AllMessenger<T> : Messenger<T, bool>
    {
        public AllMessenger(ISender<T> sender, Func<T, bool> predictate) : base(predictate)
        {
            Value = true;
            sender.Attach(this);
        }
        
        public override void Receive(T value) { Send(Value && Action(value)); }
    }
}