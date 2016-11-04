using Sparrow.Reactive;

namespace Sparrow
{
    public class Engine : EngineBase
    {
        public Engine()
        {
            frame = new Sender<FrameState>();
            action = frame.Send;
        }

        public readonly ISender<FrameState> frame;
    }
}