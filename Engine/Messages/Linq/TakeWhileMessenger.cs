using System;

namespace Sparrow.Messages.Linq
{
    public class TakeWhileMessenger<T> : Messenger<T, T>
    {
        public TakeWhileMessenger(ISender<T> sender, Func<T, bool> predictate) : base(null)
        {
            done = true;
            func = predictate;
            sender.Attach(this);
        }

        private bool done;
        private Func<T, bool> func;
        
        public override void Receive(T value)
        {
            done |= !func(value);
            if (done) return;
            Send(value);
        }
    }
}