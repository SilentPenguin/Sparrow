using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Sparrow
{
    public class FrameGenerator : IEnumerable<GameTime>
    {
        private GameTime frame;
        private Stopwatch timer;

        public IEnumerator<GameTime> GetEnumerator()
        {
            frame = new GameTime();
            timer = new Stopwatch();

            while (true)
            {
                var ticks = timer.Elapsed;
                timer.Restart();
                yield return frame += ticks;
            }
        }
        
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}