using System;
using System.Collections;
using System.Collections.Generic;

namespace Engine
{
    public class FrameGenerator : IEnumerable<FrameInfo>
    {
        private FrameInfo frame;

        public IEnumerator<FrameInfo> GetEnumerator()
        {
            frame = new FrameInfo { Time = DateTime.UtcNow };

            while (true)
                yield return frame = new FrameInfo
                (
                    lastTime: frame.Time,
                    currentTime: DateTime.UtcNow
                );
        }
        
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}