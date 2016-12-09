using System;
using System.Collections.Generic;
using System.Linq;

namespace Sparrow.Reactive.Linq
{
    public class GroupByMessenger<T, TKey> : Messenger<T, IGrouping<TKey, T>>
    {
        public GroupByMessenger(ISender<T> sender, Func<T, TKey> predictate) : base(null)
        {
            queue = new List<T>();
            func = predictate;
            sender.Attach(this);
        }

        private TKey key;
        private List<T> queue;
        private Func<T, TKey> func;
        
        public override void Receive(T value)
        {
            var receivedkey = func(value);
            
            if (!key.Equals(receivedkey))
            {
                if (queue.Any())
                {
                    Send(new Grouping<TKey, T> { Key = key, elements = queue} );
                    queue = new List<T>();
                }
                key = receivedkey;
            }
            
            queue.Add(value);
        }
    }
}