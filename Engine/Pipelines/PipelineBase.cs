using System;

namespace Engine.Pipelines
{
    public abstract class PipelineBase
    {
        public Action action;
        public FrameInfo LastProcessedFrame { get; protected set; }
        public abstract bool ProcessFrame(FrameInfo frame);
    }
}