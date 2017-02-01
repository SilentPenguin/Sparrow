using System;
using System.Collections;
using System.Collections.Generic;
using Sparrow.Sdl2;

namespace Sparrow.Events
{
    public class EventQueue : IEnumerable<object>
    {
        public IEnumerator<object> GetEnumerator()
        {
            Sdl.Event evt;
            while (Sdl.PollEvent(out evt) != 0)
            {
                switch(evt.common.type)
                {
                    case Sdl.EventType.Quit:
                        yield return evt.quit;
                        break;
                    case Sdl.EventType.KeyDown:
                    case Sdl.EventType.KeyUp:
                        yield return evt.key;
                        break;
                    case Sdl.EventType.MouseMotion:
                        yield return evt.motion;
                        break;
                    case Sdl.EventType.MouseButtonDown:
                    case Sdl.EventType.MouseButtonUp:
                        yield return evt.button;
                        break;
                    //TODO: Wrap the SDL event types, and return a common type Event instead of object
                    //this is temporarily commented out until the SDL event types are all wrapped
                    //case Sdl.EventType.Quit:
                    //    yield return new QuitEvent(evt);
                    //    break;
                    //case Sdl.EventType.KeyDown:
                    //case Sdl.EventType.KeyUp:
                    //    yield return new KeyboardEvent(evt);
                    //    break;
                    //case Sdl.EventType.MouseMotion:
                    //    yield return new MouseMoveEvent(evt);
                    //    break;
                    //case Sdl.EventType.MouseButtonDown:
                    //case Sdl.EventType.MouseButtonUp:
                    //    yield return new MouseButtonEvent(evt);
                    //    break;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
