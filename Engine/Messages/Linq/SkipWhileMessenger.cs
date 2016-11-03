using System;

namespace Sparrow.Messages.Linq
{
    public class SkipWhileMessenger<T> : Messenger<T, T>
    {
        public SkipWhileMessenger(ISender<T> sender, Func<T, bool> predictate) : base(null)
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
            if (done) Send(value);
        }
    }
}