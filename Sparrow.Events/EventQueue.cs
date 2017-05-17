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
                        yield return new ControllerAxisEvent(evt);
                        break;
                    case Sdl.EventType.ControllerButtonDown:
                        yield return new ControllerButtonDownEvent(evt);
                        break;
                    case Sdl.EventType.ControllerButtonUp:
                        yield return new ControllerButtonUpEvent(evt);
                        break;
                    case Sdl.EventType.ControllerDeviceAdded:
                        yield return new ControllerDeviceAddedEvent(evt);
                        break;
                    case Sdl.EventType.ControllerDeviceRemapped:
                        yield return new ControllerDeviceRemappedEvent(evt);
                        break;
                    case Sdl.EventType.ControllerDeviceRemoved:
                        yield return new ControllerDeviceRemovedEvent(evt);
                        break;
                    case Sdl.EventType.DollarGesture:
                        yield return new DollarGestureEvent(evt);
                        break;
                    case Sdl.EventType.DollarRecord:
                        yield return new DollarRecordEvent(evt);
                        break;
                    case Sdl.EventType.DropBegin:
                        yield return new DropBeginEvent(evt);
                        break;
                    case Sdl.EventType.DropComplete:
                        yield return new DropCompleteEvent(evt);
                        break;
                    case Sdl.EventType.DropFile:
                        yield return new DropFileEvent(evt);
                        break;
                    case Sdl.EventType.DropText:
                        yield return new DropTextEvent(evt);
                        break;
                    case Sdl.EventType.JoyAxisMotion:
                        yield return new JoystickAxisEvent(evt);
                        break;
                    case Sdl.EventType.JoyBallMotion:
                        yield return new JoystickBallEvent(evt);
                        break;
                    case Sdl.EventType.JoyButtonDown:
                        yield return new JoystickButtonDownEvent(evt);
                        break;
                    case Sdl.EventType.JoyButtonUp:
                        yield return new JoystickButtonUpEvent(evt);
                        break;
                    case Sdl.EventType.JoyDeviceAdded:
                        yield return new JoystickDeviceAddedEvent(evt);
                        break;
                    case Sdl.EventType.JoyDeviceRemoved:
                        yield return new JoystickDeviceRemovedEvent(evt);
                        break;
                    case Sdl.EventType.JoyHatMotion:
                        yield return new JoystickHatEvent(evt);
                        break;
                    case Sdl.EventType.KeyDown:
                        yield return new KeyboardKeyDownEvent(evt);
                        break;
                    case Sdl.EventType.KeyUp:
                        yield return new KeyboardKeyUpEvent(evt);
                        break;
                    case Sdl.EventType.MouseButtonDown:
                        yield return new MouseButtonDownEvent(evt);
                        break;
                    case Sdl.EventType.MouseButtonUp:
                        yield return new MouseButtonUpEvent(evt);
                        break;
                    case Sdl.EventType.MouseMotion:
                        yield return new MouseMoveEvent(evt);
                        break;
                    case Sdl.EventType.MouseWheel:
                        yield return new MouseWheelEvent(evt);
                        break;
                    case Sdl.EventType.MultiGesture:
                        yield return new MultiGestureEvent(evt);
                        break;
                    case Sdl.EventType.Quit:
                        yield return new QuitEvent(evt);
                        break;
                    case Sdl.EventType.SysWmEvent:
                        yield return new SystemWMEvent(evt);
                        break;
                    case Sdl.EventType.TextEditing:
                        yield return new TextEditingEvent(evt);
                        break;
                    case Sdl.EventType.TextInput:
                        yield return new TextInputEvent(evt);
                        break;
                    case Sdl.EventType.FingerDown:
                        yield return new TouchDownEvent(evt);
                        break;
                    case Sdl.EventType.FingerMotion:
                        yield return new TouchMoveEvent(evt);
                        break;
                    case Sdl.EventType.FingerUp:
                        yield return new TouchDownEvent(evt);
                        break;
                    case Sdl.EventType.UserEvent:
                        yield return new UserEvent(evt);
                        break;
                    case Sdl.EventType.WindowEvent:
                        yield return new WindowEvent(evt);
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
