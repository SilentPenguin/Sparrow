using System;

namespace Sparrow.Reactive.Linq
{
    public class SelectMessenger<TSource, TResult> : Messenger<TSource, TResult>
    {
        public SelectMessenger(ISender<TSource> sender, Func<TSource, TResult> predictate) : base(predictate)
        {
            sender.Attach(this);
        }
    }
}