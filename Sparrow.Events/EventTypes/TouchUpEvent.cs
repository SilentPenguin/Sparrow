using Sparrow.Sdl2;

namespace Sparrow.Events
{
    public class TouchUpEvent : Event
    {
        public TouchUpEvent(Sdl.Event evt) : base(evt) {}
    }
}
