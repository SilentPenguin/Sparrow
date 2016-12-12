using Sparrow.Numerics;
using System;
using System.Threading;
using System.Collections.Generic;

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
