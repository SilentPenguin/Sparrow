using Sparrow.Sdl2;

namespace Sparrow.Events
{
    public abstract class MouseEvent : InputDeviceEvent
    {
        public MouseEvent(Sdl.Event evt) : base(evt) {}
    }
}