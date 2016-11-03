using System;
using System.Collections.Generic;
using System.Linq;

namespace Sparrow.Messages.Linq
{
    public class GroupWhenMessenger<T, TKey> : Messenger<T, IGrouping<TKey, T>>
    {
        public GroupWhenMessenger(ISender<T> sender, ISender<TKey> trigger) : base(null)
        {
            queue = new List<T>();
            sender.Attach(this.Receive);
            trigger.Attach(this.Group);
        }

        private List<T> queue;
        
        public void Group(TKey key)
        {
            if (!queue.Any()) return;
            Send(new Grouping<TKey, T> { Key = key, elements = queue } );
            queue = new List<T>();
        }

        public override void Receive(T value)
        {
            queue.Add(value);
        }
    }
}