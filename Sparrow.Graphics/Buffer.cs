namespace Sparrow.Graphics
{
    public class Buffer<T> where T : struct
    {
        /*
        public Buffer(uint target = Raw.GL_ARRAY_BUFFER, uint usage = Raw.GL_DYNAMIC_DRAW)
        {
            var buffers = new uint[1];
            Gl.CreateBuffers(1, buffers);
            this.id = buffers[0];
            this.target = target;
            this.usage = usage;
        }

        ~Buffer()
        {
            var buffers = new uint[1] { id };
            Raw.glDeleteBuffers(1, &buffers);
        }

        private uint id;
        private uint target;
        private uint usage;

        public void Bind()
        {
            Gl.BindBuffer(target, id);
        }

        public void Unbind()
        {
            Gl.BindBuffer(target, 0);
        }

        public void Upload(T[] data)
        {
            Gl.BufferData<T>(target, data, usage);
        }
        */
    }
}