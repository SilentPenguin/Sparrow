using System;

namespace Sparrow.Reactive.Linq
{
    public class CountMessenger<T> : Messenger<T, int>
    {
        public CountMessenger(ISender<T> sender) : base(null)
        {
            Value = 0;
            sender.Attach(this);
        }
        
        public override void Receive(T value) { Send(++Value); }
    }
}