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
            frame = new FrameInfo { Time = DateTime.Now };

            while(true)
            {
                var now = DateTime.Now;
                frame = new FrameInfo
                {
                    Time = now,
                    TimeSinceLastFrame = now - frame.Time
                };
                yield return frame;
            }
        }
        
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}