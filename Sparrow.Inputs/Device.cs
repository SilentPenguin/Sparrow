using System;
namespace Sparrow.Inputs
{
    public abstract class Device
    {
        public Device(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }
    }
}
