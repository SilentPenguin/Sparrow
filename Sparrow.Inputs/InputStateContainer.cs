using System;
using Sparrow.Events;

namespace Sparrow.Inputs
{
    public class InputStateContainer
    {
        public void HandleInput(InputDeviceEvent input)
        {
            if (input is KeyboardEvent)
            {
                Console.WriteLine("Keyboard");
            }

            if (input is MouseEvent)
            {
                Console.WriteLine("Mouse");
            }
        }
    }
}