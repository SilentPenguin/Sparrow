using Engine.Pipelines;

namespace Engine
{
    public class Engine
    {
        public Engine(params PipelineBase[] pipelines)
        {
            this.frameGenerator = new FrameGenerator();
            this.pipelines = pipelines;
        }

        private FrameGenerator frameGenerator;
        private PipelineBase[] pipelines;

        public void Loop()
        {
            foreach (var frame in frameGenerator)
                foreach (var pipeline in pipelines)
                    if (pipeline.ProcessFrame(frame)) break;
        }
    }
}
