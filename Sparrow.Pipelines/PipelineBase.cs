namespace Sparrow.Pipelines
{
    public abstract class PipelineBase
    {
        public GameTime LastProcessedFrame { get; protected set; }
        public abstract void ProcessFrame(FrameState frame);
    }
}