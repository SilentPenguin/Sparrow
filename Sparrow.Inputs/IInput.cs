using System;
namespace Sparrow.Inputs
{
    public interface IInput<T>
    {
        public T Value { get; }
    }
}
