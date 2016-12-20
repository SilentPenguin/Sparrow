using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Sparrow
{
    public class FrameGenerator : IEnumerable<FrameState>
    {
        public IEnumerator<FrameState> GetEnumerator()
        {
            var frame = new GameTime();
            var timer = new Stopwatch();
            var ticks = timer.Elapsed;

            timer.Start();

            while (timer.IsRunning)
            {
                ticks = timer.Elapsed - ticks;
                frame += ticks;
                yield return new FrameState(frame);
            }
        }
        
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}