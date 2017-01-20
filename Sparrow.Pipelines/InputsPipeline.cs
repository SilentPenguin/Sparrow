using System;
using Sparrow.Sdl2;

namespace Sparrow.Pipelines
{
    public class InputsPipeline : VariableRatePipeline {
        Sdl.Event e;
        public override void ProcessFrame(FrameState frame)
        {
            while(Sdl.PollEvent(out e) != 0)
            {
                if (e.type == Sdl.EventType.Quit)
                {
                    Sdl.Quit();
                    Environment.Exit(0);
                }
            }
        }
    }
}