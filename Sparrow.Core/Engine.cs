using System;
using System.Threading;
using System.Collections.Generic;
using Sparrow.Pipelines;
using Sparrow.Numerics;

namespace Sparrow
{
    public class Engine
    {
        public Action<FrameState> action;
        private IEnumerable<GameTime> frameGenerator = new FrameGenerator();

        public void Loop()
        {
            foreach (var frame in frameGenerator)
            {
                action(new FrameState(frame));
                Thread.Sleep(0);
            }
        }
    }
}
