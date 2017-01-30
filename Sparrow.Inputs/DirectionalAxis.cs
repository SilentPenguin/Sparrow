using System;
namespace Sparrow.Inputs
{
    public class DirectionalAxis
    {
        public DirectionalAxis(IAxis horizontal, IAxis vertical)
        {
            Horizontal = horizontal;
            Vertical = vertical;
        }

        public IAxis Horizontal { get; private set; }
        public IAxis Vertical { get; private set; }
    }
}
