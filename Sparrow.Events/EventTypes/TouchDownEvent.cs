using Sparrow.Sdl2;

namespace Sparrow.Events
{
    public class TouchDownEvent : Event
    {
        public TouchDownEvent(Sdl.Event evt) : base(evt) {}
    }
}
