using System;
using System.Collections.Generic;
using System.Linq;

namespace Sparrow.Messages.Linq
{
    public class GroupOfMessenger<T> : Messenger<T, IGrouping<int, T>>
    {
        public GroupOfMessenger(ISender<T> sender, int count) : base(null)
        {
            group = new Grouping<int, T> { Key = count, elements = new List<T>() };
            sender.Attach(this);
        }

        private Grouping<int, T> group;
        
        public override void Receive(T value)
        {
            group.elements.Add(value);

            if (group.Key == group.elements.Count())
            {
                Send(group);
                group = new Grouping<int, T> {
                    Key = group.Key,
                    elements = new List<T>()
                };
            }
        }
    }
}