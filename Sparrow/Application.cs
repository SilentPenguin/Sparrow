using System;
using Sparrow.Pipelines;

namespace Sparrow
{
    public class Application
    {
        public static void Main(string args)
        {
            // The pipeline processors for our application.
            // These are responsible for consuming frames
            // created by the engine class.
            var inputs = new InputsPipeline();
            var physics = new PhysicsPipeline();
            var animation = new AnimationPipeline();
            var render = new RenderPipeline();

            var actions = new Action<FrameState>[]
            {
                inputs.ProcessFrame,
                physics.ProcessFrame,
                animation.ProcessFrame,
                render.ProcessFrame
            };

            var sequence = new SequentialPipeline(actions);

            // create our engine.
            var engine = new Engine();
            engine.action = sequence.ProcessFrame;
            engine.Loop();
        }
    }
}