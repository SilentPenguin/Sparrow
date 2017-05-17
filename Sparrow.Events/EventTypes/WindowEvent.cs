using Sparrow.Sdl2;

namespace Sparrow.Events
{
    public class WindowEvent : Event
    {
        public WindowEvent(Sdl.Event evt) : base(evt) {}
    }
}
