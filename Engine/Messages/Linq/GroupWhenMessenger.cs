using System;
using System.Collections.Generic;
using System.Linq;

namespace Sparrow.Messages.Linq
{
    public class GroupWhenMessenger<T, TKey> : Messenger<T, IGrouping<TKey, T>>
    {
        public GroupWhenMessenger(ISender<T> sender, ISender<TKey> trigger) : base(null)
        {
            group = new Grouping<TKey, T> { elements = new List<T>() };
            sender.Attach(this.Receive);
            trigger.Attach(this.Group);
        }

        private Grouping<TKey, T> group;
        
        public void Group(TKey key)
        {
            group.Key = key;
            Send(group);
            group = new Grouping<TKey, T> { elements = new List<T>() };
        }

        public override void Receive(T value)
        {
            group.elements.Add(value);
        }
    }
}