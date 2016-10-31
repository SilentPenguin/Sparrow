using System;

namespace Engine.Pipelines
{
    public abstract class PipelineBase
    {
        public FrameInfo LastProcessedFrame { get; protected set; }
        public abstract bool ProcessFrame(FrameInfo frame);
    }
}