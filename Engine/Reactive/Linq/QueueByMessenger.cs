using System;
using System.Collections.Generic;
using System.Linq;

namespace Sparrow.Reactive.Linq
{
    public class QueueByMessenger<T, TKey> : Messenger<T, T>
    {
        public QueueByMessenger(ISender<T> sender, Func<T, TKey> predictate) : base(null)
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
                foreach (var item in queue)
                    Send(item);
                queue.Clear();
            }

            key = receivedkey;
            queue.Add(value);
        }
    }
}