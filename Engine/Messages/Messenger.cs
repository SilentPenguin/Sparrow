using System;
using System.Collections.Generic;

namespace Sparrow.Messages
{
    public class Messenger<TIn, TOut> : IReceiver<TIn>, ISender<TOut>
    {
        public Messenger(Func<TIn, TOut> action)
        {
            Action = action;
            Receivers = new List<Action<TOut>>();
        }

        private Func<TIn, TOut>  Action { get; set; }
        public List<Action<TOut>> Receivers { get; private set; }

        public TOut Value { get; private set; }
        
        public void Receive(TIn value) { Send(Action(value)); }

        public void Send(TOut value)
        {
            Value = value;
            foreach(var receiver in Receivers)
                receiver(Value);
        }

        public void Attach(IReceiver<TOut> receiver) { Receivers.Add(receiver.Receive); }
        public void Attach(Action<TOut> action) { Receivers.Add(action); }
        public void Detach(IReceiver<TOut> receiver) { Receivers.Remove(receiver.Receive); }
        public void Detach(Action<TOut> action) { Receivers.Remove(action); }
    } 
}