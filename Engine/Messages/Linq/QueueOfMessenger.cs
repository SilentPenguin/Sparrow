using System;
using System.Collections.Generic;
using System.Linq;

namespace Sparrow.Messages.Linq
{
    public class QueueOfMessenger<T> : Messenger<T, T>
    {
        public QueueOfMessenger(ISender<T> sender, int count) : base(null)
        {
            queue = new List<T>();
            Count = count;
            sender.Attach(this);
        }

        private List<T> queue;
        private int Count;
        
        public override void Receive(T value)
        {
            queue.Add(value);
            if (Count != queue.Count()) return;
            foreach(var item in queue)
                Send(item);
            queue.Clear();
        }
    }
}