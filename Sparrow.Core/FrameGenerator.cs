using Sparrow.Numerics;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Sparrow
{
    public class FrameGenerator : IEnumerable<GameTime>
    {
        private GameTime frame;

        public IEnumerator<GameTime> GetEnumerator()
        {
            frame = new GameTime();
            while (true) yield return frame += DateTime.UtcNow - frame.Now;
        }
        
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}