using Sparrow.Sdl2;

namespace Sparrow.Events
{
    public class MouseButtonUpEvent : MouseButtonEvent
    {
        public MouseButtonUpEvent(Sdl.Event evt) : base(evt) {}
    }
}