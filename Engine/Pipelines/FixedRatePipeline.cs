using System;

namespace Engine.Pipelines
{
    public class FixedRatePipeline : PipelineBase
    {
        public FixedRatePipeline(int framerate)
        {
            frameDuration = TimeSpan.FromTicks(1 / framerate * TimeSpan.TicksPerMillisecond);
        }

        public Action<FrameState> action;
        private FrameState nextFixedFrame;
        private TimeSpan frameDuration;

        public override void ProcessFrame(FrameState frame)
        {
            if (nextFixedFrame.FrameInfo.Time > frame.FrameInfo.Time) return;
            action(nextFixedFrame);
            frame.HaltFrame = nextFixedFrame.HaltFrame;
            LastProcessedFrame = nextFixedFrame.FrameInfo;
            var nextFrameInfo = new FrameInfo { Time = nextFixedFrame.FrameInfo.Time + frameDuration, TimeSinceLastFrame = frameDuration };
            nextFixedFrame = new FrameState(nextFrameInfo);
        }
    }
}