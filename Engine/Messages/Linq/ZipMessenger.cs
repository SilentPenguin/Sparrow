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
        private bool senderPublished;
        private bool receiverPublished;

        private Func<TSource, TOther, TResult> Selector;
        
        public void Receive(TSource value)
        {
            senderPublished = true;
            if (receiverPublished) Send(Selector(value, Other.Value));
        }
        public void Receive(TOther value)
        {
            receiverPublished = true;
            if (senderPublished) Send(Selector(Sender.Value, value));
        }
        
        public override void Send(TResult value)
        {
            base.Send(value);
            senderPublished = receiverPublished = false;
        }
    }
}