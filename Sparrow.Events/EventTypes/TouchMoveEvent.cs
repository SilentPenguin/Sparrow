using Sparrow.Sdl2;

namespace Sparrow.Events
{
    public class TouchMoveEvent : Event
    {
        public TouchMoveEvent(Sdl.Event evt) : base(evt) {}
    }
}
