using Sparrow.Sdl2;

namespace Sparrow.Events
{
    public class QuitEvent : Event
    {
        public QuitEvent(Sdl.Event evt) : base(evt) {}
    }
}
