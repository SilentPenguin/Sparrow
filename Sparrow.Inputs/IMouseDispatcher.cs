using System;
using Sparrow.Sdl2;

namespace Sparrow.Inputs
{
    public interface IMouseDispatcher
    {
        event Action<Sdl.MouseMotionEvent> MouseMotion;
        event Action<Sdl.MouseButtonEvent> MouseButton;
        event Action<Sdl.MouseWheelEvent> MouseWheel;
    }
}