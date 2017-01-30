using System;
using Sparrow.Pipelines;
using Sparrow.Sdl2;

namespace Sparrow.Inputs
{
    public class InputsPipeline : VariableRatePipeline
    {

        EventQueue eventQueue = new EventQueue();

        public override void ProcessFrame(FrameState frame)
        {
            foreach (var evt in eventQueue)
            {
                switch (evt.type)
                {
                    case Sdl.EventType.Quit:
                        Sdl.Quit();
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}