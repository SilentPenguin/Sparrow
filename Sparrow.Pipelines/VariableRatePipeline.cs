using System;

namespace Sparrow.Pipelines
{
    public class VariableRatePipeline : PipelineBase
    {
        public Action<FrameState> action;

        public override void ProcessFrame(FrameState frame)
        {
            action(frame);
            LastFrame = frame.FrameTime;
        }
    }
}