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
                    case Sdl.EventType.ControllerAxisEvent:
                        yield return new ControllerAxisEvent();
                        break;
                    case Sdl.EventType.ControllerButtonEvent:
                        yield return new ControllerButtonEvent();
                        break;
                    case Sdl.EventType.ControllerDeviceEvent:
                        yield return new ControllerDeviceEvent();
                        break;
                    case Sdl.EventType.JoystickAxisEvent:
                        yield return new JoystickAxisEvent();
                        break;
                    case Sdl.EventType.JoystickBallEvent:
                        yield return new JoystickBallEvent();
                        break;
                    case Sdl.EventType.JoystickButtonEvent:
                        yield return new JoystickButtonEvent();
                        break;
                    case Sdl.EventType.JoystickDeviceEvent:
                        yield return new JoystickDeviceEvent();
                        break;
                    case Sdl.EventType.JoystickHatEvent:
                        yield return new JoystickHatEvent();
                        break;
                    case Sdl.EventType.KeyDown:
                    case Sdl.EventType.KeyUp:
                        yield return new KeyboardEvent();
                        break;
                    case Sdl.EventType.MouseButtonDown:
                    case Sdl.EventType.MouseButtonUp:
                        yield return new MouseButtonEvent();
                        break;
                    case Sdl.EventType.MouseMotion:
                        yield return new MouseMoveEvent();
                        break;
                    case Sdl.EventType.Quit:
                        yield return new QuitEvent();
                        break;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
