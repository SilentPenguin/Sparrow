using Sparrow.Sdl2;

namespace Sparrow.Events
{
    public class ControllerDeviceRemovedEvent : Event
    {
        public ControllerDeviceRemovedEvent(Sdl.Event evt) : base(evt) {}
    }
}