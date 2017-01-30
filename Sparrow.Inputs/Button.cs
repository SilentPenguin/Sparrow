using System;
namespace Sparrow.Inputs
{
    public class Button : IButton
    {
        public bool IsPressed { get; internal set; }
        public float Value { get { return IsPressed ? 1 : 0; } }
    }
}
