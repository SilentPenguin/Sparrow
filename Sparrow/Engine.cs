using System;
using System.Threading;
using System.Collections.Generic;

namespace Sparrow
{
    public class Engine
    {
        public Action<FrameState> action;
        private IEnumerable<FrameState> frameGenerator = new FrameGenerator();

        public void Loop()
        {
            foreach (var frame in frameGenerator)
            {
                action(frame);
                Thread.Sleep(1);
            }
        }
    }
}
