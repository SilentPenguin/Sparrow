using Sparrow.Sdl2;

namespace Sparrow.Events
{
    public class MouseWheelEvent : MouseEvent
    {
        public MouseWheelEvent(Sdl.Event evt) : base(evt) {}
    }
}