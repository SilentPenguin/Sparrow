using System;
using System.Collections.Generic;
using System.Linq;

namespace Sparrow.Messages.Linq
{
    public class QueueWhenMessenger<T, TKey> : Messenger<T, T>
    {
        public QueueWhenMessenger(ISender<T> sender, ISender<TKey> trigger) : base(null)
        {
            queue = new List<T>();
            sender.Attach(this.Receive);
            trigger.Attach(this.Flush);
        }

        private List<T> queue;
        
        public void Flush(TKey key)
        {
            foreach (var item in queue)
                Send(item);
            queue.Clear();
        }

        public override void Receive(T value)
        {
            queue.Add(value);
        }
    }
}