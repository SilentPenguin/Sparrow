using System.Collections.Generic;

namespace Sparrow.Messages.Linq
{
    public class DistinctMessenger<T> : Messenger<T, T>
    {
        public DistinctMessenger(ISender<T> sender) : base(null)
        {
            previous = new HashSet<T>();
            sender.Attach(this);
        }

        private HashSet<T> previous;
        
        public override void Receive(T value) { Send(value); }
        
        public override void Send(T value)
        {
            if (previous.Contains(value)) return;
            previous.Add(value);
            Value = value;
            foreach(var receiver in Receivers)
                receiver(Value);
        }
    }
}