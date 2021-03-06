using System;

namespace Sparrow.Reactive.Linq
{
    public class MaxSelectMessenger<T, TCompare> : Messenger<T, T> where TCompare : IComparable<TCompare>
    {
        public MaxSelectMessenger(ISender<T> sender, Func<T, TCompare> predictate) : base(null)
        {
            func = predictate;
            sender.Attach(this);
        }
        
        private TCompare max;
        private Func<T, TCompare> func;

        public override void Receive(T value)
        {
            var compare = func(value);
            if (Value != null && max.CompareTo(compare) >= 0) return;
            max = compare;
            Send(value);
        }
    }
}