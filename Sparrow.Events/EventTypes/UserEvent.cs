using Sparrow.Sdl2;

namespace Sparrow.Events
{
    public class UserEvent : Event
    {
        public UserEvent(Sdl.Event evt) : base(evt) {}
    }
}
