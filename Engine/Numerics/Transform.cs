namespace Sparrow.Numerics
{
    public class Transform
    {
        public Transform()
        {
            t = Vector.Zeros(3);
            q = Quaternion.Identity;
            s = Vector.Zeros(3);
        }
        
        public Transform(Vector translate, Quaternion rotate, Vector scale)
        {
            t = translate;
            q = rotate;
            s = scale;
        }

        public Vector Translation { get { return t; } set { t = value; m = null; } }
        public Quaternion Rotation { get { return q; } set { q = value; m = null; } }
        public Vector Scale { get { return s; } set { s = value; m = null; } }

        private Vector t;
        private Quaternion q;
        private Vector s;
        private Matrix? m = null;

        public Matrix Transformation
        {
            get
            {
                if (!m.HasValue)
                {
                    var n = q.r * q.r + q.i * q.i + q.j * q.j + q.k * q.k;
                    if (n != 0) n = 2/n;

                    double
                        ri = n * q.r * q.i, rj = n * q.r * q.j, rk = n * q.r * q.k,
                        ii = n * q.i * q.i, ij = n * q.i * q.j, ik = n * q.i * q.k,
                        jj = n * q.j * q.j, jk = n * q.j * q.k, kk = n * q.k * q.k;

                    m = new Matrix(
                        new double[4,4]
                        {
                            { s.x * (1 - (jj + kk)),       s.y * (ij - rk),       s.z * (ik + rj), t.x },
                            {       s.x * (ij + rk), s.y * (1 - (ii + kk)),       s.z * (jk - ri), t.y },
                            {       s.x * (ik - rj),       s.y * (jk + ri), s.z * (1 - (ii + jj)), t.z },
                            {                     0,                     0,                     0,   1 }
                        }
                    );
                }

                return m.Value;
            }
        }
    }
}