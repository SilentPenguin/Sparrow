using System;
namespace Sparrow.Inputs
{
    public class Device
    {
        public Device(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }
    }
}
