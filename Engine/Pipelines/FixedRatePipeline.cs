using System;

namespace Engine.Pipelines
{
    public class FixedRatePipeline : PipelineBase
    {
        public FixedRatePipeline(int framerate)
        {
            frameDuration = TimeSpan.FromTicks(1 / framerate * TimeSpan.TicksPerMillisecond);
        }

        private TimeSpan frameDuration;
        public FrameInfo nextFixedFrame { get; private set; }

        public override bool ProcessFrame(FrameInfo frame)
        {
            if (nextFixedFrame.Time > frame.Time) return false;
            action();
            LastProcessedFrame = nextFixedFrame;
            nextFixedFrame = new FrameInfo { Time = nextFixedFrame.Time + frameDuration, TimeSinceLastFrame = frameDuration };
            return true;
        }
    }
}