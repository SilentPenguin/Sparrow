using Vector = Sparrow.Numerics.Vector<float>;

namespace Sparrow.Graphics
{
    public class Vertex
    {
        public Vertex(float x, float y, float z) : this (new Vector(x, y, z)) {}
        public Vertex(Vector position) { Position = position; }
        internal int Index{ get; set; }
        public Vector Position { get; set; }
    }
}