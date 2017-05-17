using Sparrow.Sdl2;

namespace Sparrow.Events
{
    public class ControllerButtonDownEvent : Event
    {
        public ControllerButtonDownEvent(Sdl.Event evt) : base(evt) {}
    }
}