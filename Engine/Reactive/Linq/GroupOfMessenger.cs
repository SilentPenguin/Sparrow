using System;
using System.Collections.Generic;
using System.Linq;

namespace Sparrow.Reactive.Linq
{
    public class GroupOfMessenger<T> : Messenger<T, IGrouping<int, T>>
    {
        public GroupOfMessenger(ISender<T> sender, int count) : base(null)
        {
            Count = count;
            queue = new List<T>();
            sender.Attach(this);
        }

        private int Count;
        private List<T> queue;
        
        public override void Receive(T value)
        {
            queue.Add(value);

            if (Count == queue.Count())
            {
                Send(new Grouping<int, T> { Key = Count, elements = queue});
                queue = new List<T>();
            }
        }
    }
}