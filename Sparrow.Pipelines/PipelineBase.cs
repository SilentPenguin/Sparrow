using Sparrow.Numerics;

namespace Sparrow.Pipelines
{
    public abstract class PipelineBase
    {
        public GameTime LastFrame { get; protected set; }
        public abstract void ProcessFrame(FrameState frame);
    }
}