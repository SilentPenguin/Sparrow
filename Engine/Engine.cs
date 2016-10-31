using System;
using System.Threading;

namespace Engine
{
    public class Engine
    {
        public Action<FrameState> action;
        private FrameGenerator frameGenerator = new FrameGenerator();

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
