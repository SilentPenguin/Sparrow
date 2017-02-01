using System;
namespace Sparrow.Inputs
{
    public interface IAnalogueInput : IInput<float>
    {
        public float Value { get; }
    }
}
