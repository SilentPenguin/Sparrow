namespace Sparrow.Reactive.Linq
{
    public class SumMessenger<T> : Messenger<T, T> where T : struct
    {
        public SumMessenger(ISender<T> sender) : base(null)
        {
            sender.Attach(this);
        }
        
        public override void Receive(T value)
        {
            Send(Sum(Value, value));
        }

        private T Sum(T a, T b)
        {
            return ((dynamic) a + (dynamic) b);
        }
    }
}