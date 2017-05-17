using Sparrow.Sdl2;

namespace Sparrow.Events
{
    public abstract class InputDeviceEvent : Event
    {
        public InputDeviceEvent(Sdl.Event evt) : base(evt) {}
    }
}