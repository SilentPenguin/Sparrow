using Sparrow.Sdl2;

namespace Sparrow.Events
{
    public abstract class MouseButtonEvent : MouseEvent
    {
        public MouseButtonEvent(Sdl.Event evt) : base(evt) {}
    }
}