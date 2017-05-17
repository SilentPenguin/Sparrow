using Sparrow.Sdl2;

namespace Sparrow.Events
{
    public class DropFileEvent : Event
    {
        public DropFileEvent(Sdl.Event evt) : base(evt) {}
    }
}
