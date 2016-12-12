using Sparrow.Numerics;

namespace Sparrow
{
    public class FrameState
    {
        public FrameState(GameTime time)
        {
            FrameTime = time;
            HaltFrame = false;
        }

        public GameTime FrameTime { get; private set; }
        public bool HaltFrame {get; set;}
    }
}