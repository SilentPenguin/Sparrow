using System;
namespace Sparrow.Inputs
{
    public interface IAnalogueInput : IInput<float>
    {
        float Value { get; }
    }
}
