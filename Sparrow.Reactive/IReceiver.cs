namespace Sparrow.Reactive
{
    public interface IReceiver<T>
    {
        void Receive(T value);
    }
}