using System;

namespace Engine.Pipelines
{
    public class FixedRatePipeline : PipelineBase
    {
        public FixedRatePipeline(int framerate)
        {
            frameDuration = TimeSpan.FromTicks(1 / framerate * TimeSpan.TicksPerMillisecond);
        }

        public Func<FrameInfo, bool> action;
        private FrameInfo nextFixedFrame;
        private TimeSpan frameDuration;

        public override bool ProcessFrame(FrameInfo frame)
        {
            if (nextFixedFrame.Time > frame.Time) return false;
            action(nextFixedFrame);
            LastProcessedFrame = nextFixedFrame;
            nextFixedFrame = new FrameInfo { Time = nextFixedFrame.Time + frameDuration, TimeSinceLastFrame = frameDuration };
            return true;
        }
    }
}