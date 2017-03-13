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
                        yield return new ControllerButtonDownEvent();
                        break;
                    case Sdl.EventType.ControllerButtonUp:
                        yield return new ControllerButtonUpEvent();
                        break;
                    case Sdl.EventType.ControllerDeviceAdded:
                        yield return new ControllerDeviceAddedEvent();
                        break;
                    case Sdl.EventType.ControllerDeviceRemapped:
                        yield return new ControllerDeviceRemappedEvent();
                        break;
                    case Sdl.EventType.ControllerDeviceRemoved:
                        yield return new ControllerDeviceRemovedEvent();
                        break;
                    case Sdl.EventType.DollarGesture:
                        yield return new DollarGestureEvent();
                        break;
                    case Sdl.EventType.DollarRecord:
                        yield return new DollarRecordEvent();
                        break;
                    case Sdl.EventType.DropBegin:
                        yield return new DropBeginEvent();
                        break;
                    case Sdl.EventType.DropComplete:
                        yield return new DropCompleteEvent();
                        break;
                    case Sdl.EventType.DropFile:
                        yield return new DropFileEvent();
                        break;
                    case Sdl.EventType.DropText:
                        yield return new DropTextEvent();
                        break;
                    case Sdl.EventType.JoyAxisMotion:
                        yield return new JoystickAxisEvent();
                        break;
                    case Sdl.EventType.JoyBallMotion:
                        yield return new JoystickBallEvent();
                        break;
                    case Sdl.EventType.JoyButtonDown:
                        yield return new JoystickButtonDownEvent();
                        break;
                    case Sdl.EventType.JoyButtonUp:
                        yield return new JoystickButtonUpEvent();
                        break;
                    case Sdl.EventType.JoyDeviceAdded:
                        yield return new JoystickDeviceAddedEvent();
                        break;
                    case Sdl.EventType.JoyDeviceRemoved:
                        yield return new JoystickDeviceRemovedEvent();
                        break;
                    case Sdl.EventType.JoyHatMotion:
                        yield return new JoystickHatEvent();
                        break;
                    case Sdl.EventType.KeyDown:
                        yield return new KeyboardKeyDownEvent();
                        break;
                    case Sdl.EventType.KeyUp:
                        yield return new KeyboardKeyUpEvent();
                        break;
                    case Sdl.EventType.MouseButtonDown:
                        yield return new MouseButtonDownEvent();
                        break;
                    case Sdl.EventType.MouseButtonUp:
                        yield return new MouseButtonUpEvent();
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
                        yield return new TouchDownEvent();
                        break;
                    case Sdl.EventType.FingerMotion:
                        yield return new TouchMoveEvent();
                        break;
                    case Sdl.EventType.FingerUp:
                        yield return new TouchDownEvent();
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
