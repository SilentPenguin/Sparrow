using Sparrow.Sdl2;

namespace Sparrow.Events
{
    public class KeyboardKeyDownEvent : KeyboardEvent
    {
        public KeyboardKeyDownEvent(Sdl.Event evt) : base(evt) {}
    }
}