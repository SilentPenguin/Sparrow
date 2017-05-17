using Sparrow.Sdl2;

namespace Sparrow.Events
{
    public class JoystickButtonDownEvent : Event
    {
        public JoystickButtonDownEvent(Sdl.Event evt) : base(evt) {}
    }
}