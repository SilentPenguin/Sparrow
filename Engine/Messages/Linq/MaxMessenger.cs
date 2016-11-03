using System;

namespace Sparrow.Messages.Linq
{
    public class MaxMessenger<T> : Messenger<T, T> where T : IComparable<T>
    {
        public MaxMessenger(ISender<T> sender) : base(null)
        {
            sender.Attach(this);
        }
        
        public override void Receive(T value)
        {
            if (Value != null && Value.CompareTo(value) >= 0) return;
            Send(value);
        }
    }
}