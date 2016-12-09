using System.Linq;
using System.Collections.Generic;

namespace Sparrow.Graphics
{
    public class Mesh
    {
        public IList<Triangle> Triangles { get; private set; } = new List<Triangle>();
        
        internal float[] VertexArray
        {
            get
            {
                var i = 0;
                return Triangles
                    .SelectMany(t => t.Vertices)
                    .Distinct()
                    .SelectMany(v => { v.Index = i++; return v.Position; })
                    .ToArray();
            }
        }

        internal int[] IndexArray
        {
            get
            {
                return Triangles
                    .SelectMany(t => t.Vertices)
                    .Select(v => v.Index)
                    .ToArray();
            }
        }
    }
}