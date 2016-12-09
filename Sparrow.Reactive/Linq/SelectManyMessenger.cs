using System;
using System.Collections.Generic;

namespace Sparrow.Reactive.Linq
{
    public class SelectManyMessenger<TSource, TResult> : Messenger<TSource, TResult>
    {
        public SelectManyMessenger(ISender<TSource> sender, Func<TSource, IEnumerable<TResult>> predictate) : base(null)
        {
            func = predictate;
            sender.Attach(this);
        }

        private Func<TSource, IEnumerable<TResult>> func;
        
        public override void Receive(TSource value)
        {
            foreach (var item in func(value))
                Send(item);
        }
    }
}