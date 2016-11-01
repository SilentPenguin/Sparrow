using System;

namespace Sparrow.Pipelines
{
    public class SequentialPipeline : PipelineBase
    {
        public SequentialPipeline(Action<FrameState>[] actions)
        {
            this.actions = actions;    
        }

        private Action<FrameState>[] actions;

        public override void ProcessFrame(FrameState frame)
        {
            foreach (var action in actions)
            {
                if (frame.HaltFrame) break;
                action(frame);
            }
        }
    }
}