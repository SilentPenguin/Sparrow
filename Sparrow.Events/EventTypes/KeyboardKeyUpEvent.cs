using Sparrow.Sdl2;

namespace Sparrow.Events
{
    public class KeyboardKeyUpEvent : KeyboardEvent
    {
        public KeyboardKeyUpEvent(Sdl.Event evt) : base(evt) {}
    }
}