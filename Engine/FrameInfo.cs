using System;

namespace Engine
{
    public struct FrameInfo
    {
        public DateTime Now;
        public TimeSpan UpdateStep;
        public TimeSpan RenderStep;
        public bool IsUpdate;
        public bool IsRender;
    }
}