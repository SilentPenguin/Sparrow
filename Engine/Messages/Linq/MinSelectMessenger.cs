using System;

namespace Sparrow.Messages.Linq
{
    public class MinSelectMessenger<T, TCompare> : Messenger<T, T> where TCompare : IComparable<TCompare>
    {
        public MinSelectMessenger(ISender<T> sender, Func<T, TCompare> predictate) : base(null)
        {
            func = predictate;
            sender.Attach(this);
        }
        
        private TCompare min;
        private Func<T, TCompare> func;

        public override void Receive(T value)
        {
            var compare = func(value);
            if (Value != null && min.CompareTo(compare) <= 0) return;
            min = compare;
            Send(value);
        }
    }
}