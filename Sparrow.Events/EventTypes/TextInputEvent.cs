using Sparrow.Sdl2;

namespace Sparrow.Events
{
    public class TextInputEvent : Event
    {
        public TextInputEvent(Sdl.Event evt) : base(evt) {}
    }
}
