using System;
using System.Collections.Generic;
using System.Linq;

namespace Sparrow.Messages.Linq
{
    public class GroupByMessenger<T, TKey> : Messenger<T, IGrouping<TKey, T>>
    {
        public GroupByMessenger(ISender<T> sender, Func<T, TKey> predictate) : base(null)
        {
            func = predictate;
            sender.Attach(this);
        }

        private Grouping<TKey, T> group;
        private Func<T, TKey> func;
        
        public override void Receive(T value)
        {
            var key = func(value);
            
            if (group != null && group.Key.Equals(key))
            {
                Send(group);
                group = null;
            }

            if (group == null)
            {
                group = new Grouping<TKey, T>
                {
                    Key = key,
                    elements = new List<T>() { value }
                };
            }
            else if (group != null)
            {
                group.elements.Add(value);
            }
        }
    }
}