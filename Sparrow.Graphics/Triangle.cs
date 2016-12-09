namespace Sparrow.Graphics
{
    public class Triangle
    {
        public Triangle() {}
        public Triangle(Vertex a, Vertex b, Vertex c)
        {
            Vertices[0] = a;
            Vertices[1] = b;
            Vertices[2] = c;
        }

        public Vertex[] Vertices { get; private set; } = new Vertex[3];
    }
}