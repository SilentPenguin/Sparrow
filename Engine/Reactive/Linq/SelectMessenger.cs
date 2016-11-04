using System;

namespace Sparrow.Reactive.Linq
{
    public class SelectMessenger<TSource, TResult> : Messenger<TSource, TResult>
    {
        public SelectMessenger(ISender<TSource> sender, Func<TSource, TResult> selector) : base(null)
        {
            Selector = selector;
            sender.Attach(this);
        }

        private Func<TSource, TResult> Selector;
        
        public override void Receive(TSource value) { Send(Selector(value)); }
    }
}