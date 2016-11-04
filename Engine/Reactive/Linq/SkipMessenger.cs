using System;

namespace Sparrow.Reactive.Linq
{
    public class SkipMessenger<T> : Messenger<T, T>
    {
        public SkipMessenger(ISender<T> sender, int count) : base(null)
        {
            Count = count;
            sender.Attach(this);
        }

        private int Count;
        
        public override void Receive(T value)
        {
            if (Count == 0) { Send(value); return; }
            Count--;
        }
    }
}