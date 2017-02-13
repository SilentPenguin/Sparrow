using System;
namespace Sparrow.Inputs
{
    public interface IDigitalInput : IInput<bool>
    {
        bool Value { get; }
    }
}
