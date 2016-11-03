using System;

namespace Sparrow.Messages.Linq
{
    public class ZipMessenger<TSource, TOther, TResult> : Sender<TResult>, ISender<TResult>
    {
        public ZipMessenger(ISender<TSource> sender, ISender<TOther> other, Func<TSource, TOther, TResult> predictate)
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
        
        public void Receive(TSource value) { Send(value); }
        public void Receive(TOther value) { Send(value); }
        
        public void Send(TSource value)
        {
            Value = Selector(value, Other.Value);
            foreach(var receiver in Receivers)
                receiver(Value);
        }

        public void Send(TOther value)
        {
            Value = Selector(Sender.Value, value);
            foreach(var receiver in Receivers)
                receiver(Value);
        }
    }
}