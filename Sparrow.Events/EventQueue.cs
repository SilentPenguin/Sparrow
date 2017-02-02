using System;
using System.Collections;
using System.Collections.Generic;
using Sparrow.Sdl2;

namespace Sparrow.Events
{
    /// <summary>
    /// EventQueue is an iterable containing Application events, as they are
    /// iterated, they are removed from the queue.
    /// </summary>
    /// <remarks>
    /// EventQueue is a class used in combination with an EventPipeline to
    /// output Application Events each frame.
    /// </remarks>
    public class EventQueue : IEnumerable<Event>
    {
        public IEnumerator<Event> GetEnumerator()
        {
            Sdl.Event evt;
            while (Sdl.PollEvent(out evt) != 0)
            {
                switch (evt.common.type)
                {
                    case Sdl.EventType.Quit:
                        yield return new QuitEvent();
                        break;
                    case Sdl.EventType.KeyDown:
                    case Sdl.EventType.KeyUp:
                        yield return new KeyboardEvent();
                        break;
                    // case Sdl.EventType.MouseMotion:
                    //     yield return new MouseMoveEvent(evt);
                    //     break;
                    // case Sdl.EventType.MouseButtonDown:
                    // case Sdl.EventType.MouseButtonUp:
                    //     yield return new MouseButtonEvent(evt);
                    //     break;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
