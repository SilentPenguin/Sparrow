using System;

namespace Engine
{
    public class Engine
    {
        public Func<FrameInfo, bool> action;
        private FrameGenerator frameGenerator = new FrameGenerator();

        public void Loop()
        {
            foreach (var frame in frameGenerator)
                action(frame);
        }
    }
}
