namespace Sparrow.Numerics
{
    public class Transform
    {
        public Vector Translation { get; set; }
        public Quaternion Rotation { get; set; }
        public Vector Scale { get; set; }

        private Matrix? transformation;
        public Matrix Transformation
        {
            get
            {
                if (!transformation.HasValue)
                {
                    var t = Translation;
                    var q = Rotation;
                    var s = Scale;

                    var n = q.r * q.r + q.i * q.i + q.j * q.j + q.k * q.k;
                    if (n != 0) n = 2/n;
                    double
                        ri = n * q.r * q.i, rj = n * q.r * q.j, rk = n * q.r * q.k,
                        ii = n * q.i * q.i, ij = n * q.i * q.j, ik = n * q.i * q.k,
                        jj = n * q.j * q.j, jk = n * q.j * q.k, kk = n * q.k * q.k;

                    transformation = new Matrix(
                        new double[4,4]{
                            { s.x - (jj + kk),         ij - rk,         ik + rj, t.x },
                            {         ij + rk, s.y - (ii + kk),         jk - ri, t.y },
                            {         ik - rj,         jk + ri, s.z - (ii + jj), t.z },
                            {               0,               0,               0,   1 }
                        }
                    );
                }

                return transformation.Value;
            }
        }

        public double RotS(double a, double b) { return RotS(a, a, b, b); }
        public double Rot(double a, double b, double c, double d) { return 2 * a * b + 2 * c * d; }
        public double RotS(double a, double b, double c, double d) { return 2 * a * b - 2 * c * d; }
    }
}