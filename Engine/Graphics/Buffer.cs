using Sparrow.Graphics.OpenGL;
using System.Runtime.InteropServices;

namespace Sparrow.Graphics
{
    public class Buffer<T> where T : struct
    {
        public Buffer()
        {
            var buffers = new uint[1];
            //target = Gl.glCreateBuffers(1, buffers);
        }

        public uint target;

        public void Bind()
        {

        }
    }
}