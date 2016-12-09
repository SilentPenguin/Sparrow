using System;

namespace Sparrow.Reactive.Linq
{
    public class ContainsMessenger<T> : Messenger<T, bool> where T : IEquatable<T>
    {
        public ContainsMessenger(ISender<T> sender, T value) : base(null)
        {
            ContainsValue = value;
            sender.Attach(this);
        }

        private T ContainsValue;
        
        public override void Receive(T value) { Send(ContainsValue.Equals(value)); }
        
        public override void Send(bool value)
        {
            Value = value;
            foreach(var receiver in Receivers)
                receiver(Value);
        }
    }
}