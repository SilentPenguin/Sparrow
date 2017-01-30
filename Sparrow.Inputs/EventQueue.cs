using System;
using System.Collections;
using System.Collections.Generic;
using Sparrow.Sdl2;

namespace Sparrow.Inputs
{
    public class EventQueue : IEnumerable<Sdl.Event>
    {
        public IEnumerator<Sdl.Event> GetEnumerator()
        {
            Sdl.Event evt;
            while (Sdl.PollEvent(out evt) != 0)
            {
                yield return evt;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
