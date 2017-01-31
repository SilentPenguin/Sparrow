using System;
using Sparrow.Pipelines;
using Sparrow.Sdl2;

namespace Sparrow.Inputs
{
    public class InputsPipeline : VariableRatePipeline, IMouseDispatcher, IKeyboardDispatcher
    {

        public InputsPipeline()
        {
            Mouse = new Mouse(this);
        }

        private readonly EventQueue eventQueue = new EventQueue();

        public event Action<Sdl.QuitEvent> Quit;
        public event Action<Sdl.KeyboardEvent> KeyboardKey;
        public event Action<Sdl.MouseMotionEvent> MouseMotion;
        public event Action<Sdl.MouseButtonEvent> MouseButton;
        public event Action<Sdl.MouseWheelEvent> MouseWheel;

        public Mouse Mouse { get; private set; }

        public override void ProcessFrame(FrameState frame)
        {
            foreach (var evt in eventQueue)
            {
                switch (evt.type)
                {
                    case Sdl.EventType.Quit:
                        Quit(evt.quit);
                        break;
                    case Sdl.EventType.KeyDown:
                    case Sdl.EventType.KeyUp:
                        KeyboardKey(evt.key);
                        break;
                    case Sdl.EventType.MouseMotion:
                        MouseMotion(evt.motion);
                        break;
                    case Sdl.EventType.MouseButtonDown:
                    case Sdl.EventType.MouseButtonUp:
                        MouseButton(evt.button);
                        break;
                    case Sdl.EventType.MouseWheel:
                        MouseWheel(evt.wheel);
                        break;
                }
            }
        }
    }
}