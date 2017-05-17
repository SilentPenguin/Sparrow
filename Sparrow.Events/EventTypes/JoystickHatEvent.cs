using Sparrow.Sdl2;

namespace Sparrow.Events
{
    public class JoystickHatEvent : Event
    {
        public JoystickHatEvent(Sdl.Event evt) : base(evt) {}
    }
}