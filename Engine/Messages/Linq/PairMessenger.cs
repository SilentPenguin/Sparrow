using System;

namespace Sparrow.Messages.Linq
{
    public class PairMessenger<TSource, TOther, TResult> : Sender<TResult>, ISender<TResult>
    {
        public PairMessenger(ISender<TSource> sender, ISender<TOther> other, Func<TSource, TOther, TResult> predictate)
        {
            Selector = predictate;
            Sender = sender;
            Other = other;
            Sender.Attach(this.Receive);
            Other.Attach(this.Receive);
        }

        private ISender<TSource> Sender;
        private ISender<TOther> Other;

        private Func<TSource, TOther, TResult> Selector;
        
        public void Receive(TSource value) { Send(Selector(value, Other.Value)); }
        public void Receive(TOther value) { Send(Selector(Sender.Value, value)); }
    }
}