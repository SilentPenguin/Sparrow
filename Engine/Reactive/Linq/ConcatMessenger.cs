using System;

namespace Sparrow.Reactive.Linq
{
    public class ConcatMessenger<T> : Messenger<T, T>
    {
        public ConcatMessenger(ISender<T> sender, ISender<T> other) : base(null)
        {
            sender.Attach(this);
            other.Attach(this);
        }

        public override void Receive(T value) { Send(value); }
    }
}