using System;

namespace Engine.Limiters
{
    public class VariableLimiter : FrameGeneratorBase
    {
        private DateTime lastFrame;

        protected override FrameInfo NextFrame()
        {
            var current = DateTime.Now;
            var elapsed = current - lastFrame;
            lastFrame = current;
            return new FrameInfo {
                Now = current,
                UpdateStep = elapsed,
                RenderStep = TimeSpan.Zero,
                IsUpdate = true,
                IsRender = true
            };
        }
    }
}