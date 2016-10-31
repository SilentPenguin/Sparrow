namespace Engine.Messages
{
    public interface IReceiver<T>
    {
        void Receive(T value);
    }
}