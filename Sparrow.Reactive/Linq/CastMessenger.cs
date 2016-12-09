namespace Sparrow.Reactive.Linq
{
    public class CastMessenger<TSource, TResult> : Messenger<TSource, TResult> where TSource : TResult
    {
        public CastMessenger(ISender<TSource> sender) : base(null)
        {
            sender.Attach(this);
        }

        public override void Receive(TSource value) { Send((TResult)value); }
    }
}