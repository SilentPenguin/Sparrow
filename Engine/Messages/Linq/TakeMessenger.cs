using System;

namespace Sparrow.Messages.Linq
{
    public class TakeMessenger<T> : Messenger<T, T>
    {
        public TakeMessenger(ISender<T> sender, int count) : base(null)
        {
            Count = count;
            sender.Attach(this);
        }

        private int Count;
        
        public override void Receive(T value)
        {
            if (Count == 0) return;
            Count--;
            Send(value);
        }
    }
}