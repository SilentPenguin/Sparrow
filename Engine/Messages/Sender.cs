using System;
using System.Collections.Generic;

namespace Engine.Messages
{
    public class Sender<T> : ISender<T>
    {
        public Sender() { Receivers = new List<Action<T>>(); }

        public List<Action<T>> Receivers { get; private set; }

        public T Value { get; private set; }
        
        public void Send(T value)
        {
            Value = value;
            foreach(var receiver in Receivers)
                receiver(value);
        }

        public void Attach (IReceiver<T> receiver) { Receivers.Add(receiver.Receive); }
        public void Attach (Action<T> action) { Receivers.Add(action); }
        public void Detach (IReceiver<T> receiver) { Receivers.Remove(receiver.Receive); }
        public void Detach (Action<T> action) { Receivers.Remove(action); }
    } 
}