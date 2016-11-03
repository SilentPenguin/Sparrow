using System;
using System.Collections.Generic;

namespace Sparrow.Messages
{
    public class Messenger<TSource, TResult> : IReceiver<TSource>, ISender<TResult>
    {
        public Messenger(Func<TSource, TResult> action)
        {
            Action = action;
            Receivers = new List<Action<TResult>>();
        }

        protected Func<TSource, TResult>  Action { get; set; }
        public List<Action<TResult>> Receivers { get; private set; }

        public TResult Value { get; protected set; }
        
        public virtual void Receive(TSource value) { Send(Action(value)); }

        public virtual void Send(TResult value)
        {
            Value = value;
            foreach(var receiver in Receivers)
                receiver(Value);
        }

        public void Attach(IReceiver<TResult> receiver) { Receivers.Add(receiver.Receive); }
        public void Attach(Action<TResult> action) { Receivers.Add(action); }
        public void Detach(IReceiver<TResult> receiver) { Receivers.Remove(receiver.Receive); }
        public void Detach(Action<TResult> action) { Receivers.Remove(action); }
    } 
}