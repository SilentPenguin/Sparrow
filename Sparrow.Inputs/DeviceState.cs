using System;

namespace Sparrow.Inputs
{
    public struct DeviceState
    {
        public InputState<bool>[] digitalInputStates;
        public InputState<float>[] analogueInputStates;
    }
}