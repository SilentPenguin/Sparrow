using System;
using Sparrow.Pipelines;

namespace Sparrow
{
    public class Application
    {
        public static void Main(string args)
        {
            // The pipeline processors for our application
            var inputs = new InputsPipeline();
            var physics = new PhysicsPipeline();
            var animation = new AnimationPipeline();
            var render = new RenderPipeline();
            
            var actions = new Action<FrameState>[]{
                inputs.ProcessFrame, physics.ProcessFrame,
                animation.ProcessFrame, render.ProcessFrame
            };

            var sequence = new SequentialPipeline(actions);

            var engine = new Engine();
            engine.action = sequence.ProcessFrame;
            engine.Loop();
        }
    }
}