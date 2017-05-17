using Sparrow.Sdl2;

namespace Sparrow.Events
{
    public class MouseButtonDownEvent : MouseButtonEvent
    {
        public MouseButtonDownEvent(Sdl.Event evt) : base(evt) {}
    }
}