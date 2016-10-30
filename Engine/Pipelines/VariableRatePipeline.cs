namespace Engine.Pipelines
{
    public class VariableRatePipeline : PipelineBase
    {
        public override bool ProcessFrame(FrameInfo frame) {
            action();
            LastProcessedFrame = frame;
            return false;
        }
    }
}