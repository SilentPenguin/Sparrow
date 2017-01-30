using System;
using Sparrow.Sdl2;

namespace Sparrow.Inputs
{
    public class Mouse : Device
    {

        public Button Left { get; private set; }
        public Button Right { get; private set; }
        public Button Middle { get; private set; }
        public Button Forward { get; private set; }
        public Button Backward { get; private set; }

        public Mouse () : base("Mouse")
        {
            Left = new Button();
            Right = new Button();
            Middle = new Button();
            Forward = new Button();
            Backward = new Button();
        }

        internal void OnMouseButton(Sdl.MouseButtonEvent evt)
        {
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

        }

        internal void OnMouseWheel(Sdl.MouseWheelEvent evt)
        {
        
        }
    }
}
