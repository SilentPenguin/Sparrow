using Sparrow.Sdl2;

namespace Sparrow.Events
{
    public class ControllerAxisEvent : Event
    {
        public ControllerAxisEvent(Sdl.Event evt) : base(evt) {}
    }
}