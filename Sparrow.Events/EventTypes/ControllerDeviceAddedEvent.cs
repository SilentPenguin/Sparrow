using Sparrow.Sdl2;

namespace Sparrow.Events
{
    public class ControllerDeviceAddedEvent : Event
    {
        public ControllerDeviceAddedEvent(Sdl.Event evt) : base(evt) {}
    }
}