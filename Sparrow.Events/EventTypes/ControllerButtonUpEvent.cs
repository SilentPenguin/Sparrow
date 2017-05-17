using Sparrow.Sdl2;

namespace Sparrow.Events
{
    public class ControllerButtonUpEvent : Event
    {
        public ControllerButtonUpEvent(Sdl.Event evt) : base(evt) {}
    }
}