using System;

namespace Engine.Pipelines
{
    public class VariableRatePipeline : PipelineBase
    {
        public Func<FrameInfo, bool> action;

        public override bool ProcessFrame(FrameInfo frame) {
            action(frame);
            LastProcessedFrame = frame;
            return false;
        }
    }
}