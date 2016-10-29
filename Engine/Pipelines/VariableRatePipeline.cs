namespace Engine.Pipelines
{
    public class VariableRatePipeline : IPipeline
    {
        public void RunFrame(FrameInfo frame) {
            DoFrame(frame);
        }
        public void DoFrame(FrameInfo frame) {}
    }
}