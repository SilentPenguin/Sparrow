using System;

namespace Sparrow.Reactive.Linq
{
    public class MinMessenger<T> : Messenger<T, T> where T : IComparable<T>
    {
        public MinMessenger(ISender<T> sender) : base(null)
        {
            sender.Attach(this);
        }
        
        public override void Receive(T value)
        {
            if (Value != null && Value.CompareTo(value) <= 0) return;
            Send(value);
        }
    }
}