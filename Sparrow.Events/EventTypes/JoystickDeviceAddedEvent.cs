using Sparrow.Sdl2;

namespace Sparrow.Events
{
    public class JoystickDeviceAddedEvent : Event
    {
        public JoystickDeviceAddedEvent(Sdl.Event evt) : base(evt) {}
    }
}