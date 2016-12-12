using System;

namespace Sparrow.Pipelines
{
    public class FixedRatePipeline : PipelineBase
    {
        public FixedRatePipeline(int framerate = 60)
        {
            frameDuration = TimeSpan.FromTicks(1 / framerate * TimeSpan.TicksPerMillisecond);
        }

        public Action<FrameState> action;
        private FrameState nextFrame;
        private TimeSpan frameDuration;

        public override void ProcessFrame(FrameState frame)
        {
            if (nextFrame.FrameTime > frame.FrameTime) return;
            action(nextFrame);
            frame.HaltFrame = nextFrame.HaltFrame;
            LastProcessedFrame = nextFrame.FrameTime;
            nextFrame = new FrameState(nextFrame.FrameTime + frameDuration);
        }
    }
}