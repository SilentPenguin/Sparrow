namespace Sparrow.Pipelines
{
    public class AnimationPipeline : VariableRatePipeline
    {
        public AnimationPipeline()
        {
            Reference = this;
        }

        public AnimationPipeline(PipelineBase TimeReference)
        {
            Reference = TimeReference;
        }

        private PipelineBase Reference;

        public override void ProcessFrame(FrameState frame)
        {
            // Rebuild our time against the reference pipeline
            var step = frame.FrameTime - Reference.LastFrame;
            var animation = new FrameState(Reference.LastFrame + step);
            base.ProcessFrame(animation);
            frame.HaltFrame = animation.HaltFrame;
        }
    }
}