using System;

namespace Sparrow
{
    public struct FrameInfo
    {
        public FrameInfo(DateTime lastTime, DateTime currentTime)
        {
            Time = currentTime;
            TimeSinceLastFrame = currentTime - lastTime;
        }
        public DateTime Time;
        public TimeSpan TimeSinceLastFrame;
    }
}