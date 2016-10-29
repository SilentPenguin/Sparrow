using System;

namespace Engine.Limiters
{
    public class FixedFramerate : FrameGeneratorBase
    {

        public FixedFramerate(int framerate = 60)
        {
            frameDuration = TimeSpan.FromTicks(1 / framerate * TimeSpan.TicksPerMillisecond);
        }

        private TimeSpan frameDuration;
        private DateTime nextFrame;

        protected override FrameInfo NextFrame()
        {
            var current = DateTime.Now;
            var update = nextFrame < current;
            if (update) nextFrame += frameDuration;
            return new FrameInfo
            {
                Now = current,
                UpdateStep = frameDuration,
                RenderStep = current - nextFrame,
                IsUpdate = update,
                IsRender = !update
            };
        }
    }
}