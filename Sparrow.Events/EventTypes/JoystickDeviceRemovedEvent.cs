using Sparrow.Sdl2;

namespace Sparrow.Events
{
    public class JoystickDeviceRemovedEvent : Event
    {
        public JoystickDeviceRemovedEvent(Sdl.Event evt) : base(evt) {}
    }
}