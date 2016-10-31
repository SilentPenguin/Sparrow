using System;
using System.Threading;

namespace Engine
{
    public class Engine
    {
        public Func<FrameInfo, bool> action;
        private FrameGenerator frameGenerator = new FrameGenerator();

        public void Loop()
        {
            foreach (var frame in frameGenerator)
            {
                action(frame);
                Thread.Sleep(0);
            }
        }
    }
}
