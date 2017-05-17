using Sparrow.Sdl2;

namespace Sparrow.Events
{
    public abstract class KeyboardEvent : InputDeviceEvent
    {
        public KeyboardEvent(Sdl.Event evt) : base(evt) {}
    }
}