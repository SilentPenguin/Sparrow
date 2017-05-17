using Sparrow.Sdl2;

namespace Sparrow.Events
{
    public class JoystickButtonUpEvent : Event
    {
        public JoystickButtonUpEvent(Sdl.Event evt) : base(evt) {}
    }
}