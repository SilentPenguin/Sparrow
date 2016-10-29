using System;

namespace Engine.Pipelines
{
    public class FixedRatePipeline : IPipeline
    {
        public FixedRatePipeline(int framerate)
        {
            frameDuration = TimeSpan.FromTicks(1 / framerate * TimeSpan.TicksPerMillisecond);
        }

        private TimeSpan frameDuration;
        public FrameInfo physicsFrame { get; private set; }

        public void RunFrame(FrameInfo frame)
        {
            while (physicsFrame.Time < frame.Time)
            {
                DoFrame(physicsFrame);
                physicsFrame = new FrameInfo { Time = physicsFrame.Time + frameDuration, TimeSinceLastFrame = frameDuration };
            }
        }
        
        public void DoFrame(FrameInfo frame) {}
    }
}