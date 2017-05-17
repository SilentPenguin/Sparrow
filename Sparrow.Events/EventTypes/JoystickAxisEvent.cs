using Sparrow.Sdl2;

namespace Sparrow.Events
{
    public class JoystickAxisEvent : Event
    {
        public JoystickAxisEvent(Sdl.Event evt) : base(evt) {}
    }
}