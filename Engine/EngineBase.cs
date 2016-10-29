using System;

namespace Engine
{
    public abstract class EngineBase {
        public FrameGeneratorBase limiter;

        public abstract void Update(TimeSpan step);
        public abstract void Render(TimeSpan step);

        public void Loop()
        {
            if (limiter.IsStopped) return;
            foreach(var frame in limiter)
            {
                if (frame.IsUpdate) Update(frame.UpdateStep);
                if (frame.IsRender) Render(frame.RenderStep);
            }
        }
    }
}