using System;
namespace Sparrow.Inputs
{
    public class DirectionalAxis
    {
        public DirectionalAxis()
        {
            Horizontal = new Axis();
            Vertical = new Axis();
        }

        public Axis Horizontal { get; private set; }
        public Axis Vertical { get; private set; }
    }
}
