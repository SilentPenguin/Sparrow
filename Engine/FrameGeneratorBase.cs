using System.Collections;
using System.Collections.Generic;

namespace Engine
{
    public abstract class FrameGeneratorBase : IEnumerable<FrameInfo>
    {
        public bool IsStopped { get; private set; }
        protected void Start(){ IsStopped = false; }
        public void Stop () { IsStopped = true; }
        protected abstract FrameInfo NextFrame();

        public IEnumerator<FrameInfo> GetEnumerator()
        {
            Start();
            while(!IsStopped)
            {
                yield return NextFrame();
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}