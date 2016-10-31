using System;

namespace Engine.Pipelines
{
    public class SequentialPipeline : PipelineBase
    {
        public SequentialPipeline(Func<FrameInfo, bool>[] actions)
        {
            this.actions = actions;    
        }

        private Func<FrameInfo, bool>[] actions;

        public override bool ProcessFrame(FrameInfo frame)
        {
            foreach (var pipeline in actions)
                if (pipeline(frame)) return true;
            return false;
        }
    }
}