using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Sparrow.Numerics;

namespace Sparrow
{
    public class FrameGenerator : IEnumerable<GameTime>
    {
        public IEnumerator<GameTime> GetEnumerator()
        {
            var frame = new GameTime();
            var timer = new Stopwatch();
            var ticks = timer.Elapsed;

            timer.Start();

            while (timer.IsRunning)
            {
                ticks = timer.Elapsed - ticks;
                yield return frame += ticks;
            }
        }
        
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}