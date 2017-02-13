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
                    case Sdl.EventType.ControllerAxisMotion:
                        yield return new ControllerAxisEvent();
                        break;
                    case Sdl.EventType.ControllerButtonDown:
                    case Sdl.EventType.ControllerButtonUp:
                        yield return new ControllerButtonEvent();
                        break;
                    case Sdl.EventType.ControllerDeviceAdded:
                    case Sdl.EventType.ControllerDeviceRemoved:
                    case Sdl.EventType.ControllerDeviceRemapped:
                        yield return new ControllerDeviceEvent();
                        break;
                    case Sdl.EventType.DollarGesture:
                        yield return new DollarGestureEvent();
                        break;
                    case Sdl.EventType.DropBegin:
                    case Sdl.EventType.DropComplete:
                    case Sdl.EventType.DropFile:
                    case Sdl.EventType.DropText:
                        yield return new DropEvent();
                        break;
                    case Sdl.EventType.JoyAxisMotion:
                        yield return new JoystickAxisEvent();
                        break;
                    case Sdl.EventType.JoyBallMotion:
                        yield return new JoystickBallEvent();
                        break;
                    case Sdl.EventType.JoyButtonDown:
                    case Sdl.EventType.JoyButtonUp:
                        yield return new JoystickButtonEvent();
                        break;
                    case Sdl.EventType.JoyDeviceAdded:
                    case Sdl.EventType.JoyDeviceRemoved:
                        yield return new JoystickDeviceEvent();
                        break;
                    case Sdl.EventType.JoyHatMotion:
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
                    case Sdl.EventType.MouseWheel:
                        yield return new MouseWheelEvent();
                        break;
                    case Sdl.EventType.MultiGesture:
                        yield return new MultiGestureEvent();
                        break;
                    case Sdl.EventType.Quit:
                        yield return new QuitEvent();
                        break;
                    case Sdl.EventType.SysWmEvent:
                        yield return new SystemWMEvent();
                        break;
                    case Sdl.EventType.TextEditing:
                        yield return new TextEditingEvent();
                        break;
                    case Sdl.EventType.TextInput:
                        yield return new TextInputEvent();
                        break;
                    case Sdl.EventType.FingerDown:
                    case Sdl.EventType.FingerMotion:
                    case Sdl.EventType.FingerUp:
                        yield return new TouchFingerEvent();
                        break;
                    case Sdl.EventType.UserEvent:
                        yield return new UserEvent();
                        break;
                    case Sdl.EventType.WindowEvent:
                        yield return new WindowEvent();
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
