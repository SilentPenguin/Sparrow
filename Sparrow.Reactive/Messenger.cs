using System;
using System.Collections.Generic;

namespace Sparrow.Reactive
{
    public class Messenger<T> : Messenger<T,T>
    {
        public Messenger(Action<T> action) : base(action) {}
    }

    public class Messenger<TSource, TResult> : IMessenger<TSource, TResult>
    {
        public Messenger(Action<TSource> action)
        {
            Action = action;
            Receivers = new List<Action<TResult>>();
        }

        protected Action<TSource>  Action { get; set; }
        public List<Action<TResult>> Receivers { get; private set; }

        public TResult Value { get; protected set; }
        
        public virtual void Receive(TSource value) { Action(value); }

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