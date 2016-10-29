using System;

namespace Engine
{
    public struct FrameInfo
    {
        public DateTime Time;
        public TimeSpan TimeSinceLastFrame;
    }
}