namespace Engine.Pipelines
{
    public abstract class PipelineBase
    {
        public FrameInfo LastProcessedFrame { get; protected set; }
        public abstract void ProcessFrame(FrameState frame);
    }
}