namespace Engine.Pipelines
{
    public interface IPipeline
    {
        void RunFrame(FrameInfo frame);
        void DoFrame(FrameInfo frame);
    }
}