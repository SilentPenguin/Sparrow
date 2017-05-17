using Sparrow.Sdl2;

namespace Sparrow.Events
{
    public class MouseMoveEvent : MouseEvent
    {
        public MouseMoveEvent(Sdl.Event evt) : base(evt) {}
    }
}