using System;
namespace Sparrow.Inputs
{
    public interface IDigitalInput : IInput<bool>
    {
        public bool Value { get; }
    }
}
