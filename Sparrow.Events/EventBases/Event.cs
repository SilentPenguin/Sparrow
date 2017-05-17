using Sparrow.Sdl2;

namespace Sparrow.Events
{
    public abstract class Event {
        public readonly uint timestamp;

        public Event(Sdl.Event evt)
        {
            timestamp = evt.common.timestamp;
        }
    }
}