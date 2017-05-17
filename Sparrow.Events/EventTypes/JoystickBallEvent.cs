using Sparrow.Sdl2;

namespace Sparrow.Events
{
    public class JoystickBallEvent : Event
    {
        public JoystickBallEvent(Sdl.Event evt) : base(evt) {}
    }
}