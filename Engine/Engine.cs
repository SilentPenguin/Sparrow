using Engine.Pipelines;

namespace Engine
{
    public class Engine
    {
        public Engine(params IPipeline[] pipelines)
        {
            this.frameGenerator = new FrameGenerator();
            this.pipelines = pipelines;
        }

        private FrameGenerator frameGenerator;
        private IPipeline[] pipelines;

        public void Loop()
        {
            foreach (var frame in frameGenerator)
                foreach (var pipeline in pipelines)
                    pipeline.RunFrame(frame);
        }
    }
}
