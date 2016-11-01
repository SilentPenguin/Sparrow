namespace Sparrow.Messages
{
    public interface IReceiver<T>
    {
        void Receive(T value);
    }
}