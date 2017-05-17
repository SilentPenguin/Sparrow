using Sparrow.Sdl2;

namespace Sparrow.Events
{
    public class ControllerDeviceRemappedEvent : Event
    {
        public ControllerDeviceRemappedEvent(Sdl.Event evt) : base(evt) {}
    }
}