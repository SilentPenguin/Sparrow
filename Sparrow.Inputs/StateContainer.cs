using System;
using Sparrow.Sdl2;
using Sparrow.Events;

namespace Sparrow.Inputs
{
    public class StateContainer
    {
        public void Attach(EventPipeline pipeline)
        {
            pipeline.Subscribe<Sdl.MouseMotionEvent>(HandleMouseMoved);
            pipeline.Subscribe<Sdl.MouseButtonEvent>(HandleMouseButton);
            pipeline.Subscribe<Sdl.KeyboardEvent>(HandleKeyboard);
        }

        public void Detach(EventPipeline pipeline)
        {
            pipeline.Unsubscribe<Sdl.MouseMotionEvent>();
            pipeline.Unsubscribe<Sdl.MouseButtonEvent>();
            pipeline.Unsubscribe<Sdl.KeyboardEvent>();
        }

        private void HandleKeyboard(Sdl.KeyboardEvent Keyboard)
        {
            Console.WriteLine("Keyboard");
        }

        private void HandleMouseMoved(Sdl.MouseMotionEvent motion)
        {
            Console.WriteLine("MouseMoved");
        }

        private void HandleMouseButton(Sdl.MouseButtonEvent button)
        {
            Console.WriteLine("MouseButton");
        }


    }
}