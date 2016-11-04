namespace Sparrow.Reactive
{
    public interface IMessenger<TIn, TOut> : IReceiver<TIn>, ISender<TOut> {}
}