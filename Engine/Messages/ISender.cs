using System;

namespace Sparrow.Messages
{
    public interface ISender<T>
    {
        T Value { get; }
        void Send(T Value);
        void Attach(IReceiver<T> receiver);
        void Attach(Action<T> receiver);
        void Detach(Action<T> receiver);
        void Detach(IReceiver<T> receiver);
    }
}