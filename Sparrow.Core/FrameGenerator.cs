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
            var last = timer.Elapsed;

            timer.Start();

            while (timer.IsRunning)
            {
                var current = timer.Elapsed;
                frame += current - last;
                last = current;
                yield return new FrameState(frame);
            }
        }
        
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}