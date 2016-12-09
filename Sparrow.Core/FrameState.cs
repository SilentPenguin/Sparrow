namespace Sparrow
{
    public class FrameState
    {
        public FrameState(FrameInfo frame)
        {
            FrameInfo = frame;
            HaltFrame = false;
        }

        public FrameInfo FrameInfo { get; private set; }
        public bool HaltFrame {get; set;}
    }
}