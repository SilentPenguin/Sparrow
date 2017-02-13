using System;
namespace Sparrow.Inputs
{
    public interface IInput<T>
    {
        T Value { get; }
    }
}
