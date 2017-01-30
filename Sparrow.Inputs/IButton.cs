using System;
namespace Sparrow.Inputs
{
    public interface IButton : IInput
    {
        bool IsPressed { get; }
    }
}
