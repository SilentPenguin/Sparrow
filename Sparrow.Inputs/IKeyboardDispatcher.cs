using System;
using Sparrow.Sdl2;

namespace Sparrow.Inputs
{
    public interface IKeyboardDispatcher
    {
        event Action<Sdl.KeyboardEvent> KeyboardKey;
    }
}