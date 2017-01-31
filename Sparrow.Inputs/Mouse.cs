using System;
using Sparrow.Sdl2;

namespace Sparrow.Inputs
{
    public class Mouse : Device
    {
        public int? Id { get; private set; }

        public Button Left { get; private set; }
        public Button Right { get; private set; }
        public Button Middle { get; private set; }
        public Button Forward { get; private set; }
        public Button Backward { get; private set; }

        public DirectionalAxis Wheel { get; private set; }
        public DirectionalAxis Position { get; private set; }
        public DirectionalAxis Velocity { get; private set; }

        public Mouse (IMouseDispatcher dispatch, int? id = null) : base("Mouse")
        {
            Id = id;

            dispatch.MouseMotion += OnMouseMove;
            dispatch.MouseButton += OnMouseButton;
            dispatch.MouseWheel += OnMouseWheel;

            Left = new Button();
            Right = new Button();
            Middle = new Button();
            Forward = new Button();
            Backward = new Button();

            Position = new DirectionalAxis();
            Velocity = new DirectionalAxis();
        }

        internal void OnMouseButton(Sdl.MouseButtonEvent evt)
        {
            if (Id.HasValue && Id != evt.which) return;

            Button button; 
            switch(evt.button)
            {
                case Sdl.MouseButton.Left:
                    button = Left;
                    break;
                case Sdl.MouseButton.Right:
                    button = Right;
                    break;
                case Sdl.MouseButton.Middle:
                    button = Middle;
                    break;
                case Sdl.MouseButton.X1:
                    button = Forward;
                    break;
                case Sdl.MouseButton.X2:
                    button = Backward;
                    break;
                default:
                    return;
            }
            button.IsPressed = evt.state == Sdl.ButtonState.Pressed;
        }

        internal void OnMouseMove(Sdl.MouseMotionEvent evt)
        {
            if (Id.HasValue && Id != evt.which) return;

            Position.Horizontal.Value = evt.x;
            Position.Vertical.Value = evt.y;
            Velocity.Horizontal.Value = evt.xrel;
            Velocity.Vertical.Value = evt.yrel;
        }

        internal void OnMouseWheel(Sdl.MouseWheelEvent evt)
        {
            if (Id.HasValue && Id != evt.which) return;

            Wheel.Horizontal.Value = evt.x;
            Wheel.Vertical.Value = evt.y;
        }
    }
}
