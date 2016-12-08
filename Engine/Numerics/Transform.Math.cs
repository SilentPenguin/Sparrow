namespace Sparrow.Numerics
{
    public partial class Transform<T> where T : struct
    {
        abstract class Math<S> where S : struct
        {
            public abstract Matrix<S> Matrix(Vector<S> translate, Quaternion<S> rotate, Vector<S> scale);
        }

        class MathFloat : Math<float>
        {
            public override Matrix<float> Matrix(Vector<float> t, Quaternion<float> q, Vector<float> s)
            {
                var n = q.r * q.r + q.i * q.i + q.j * q.j + q.k * q.k;
                if (n != 0) n = 2/n;

                float
                ri = n * q.r * q.i, rj = n * q.r * q.j, rk = n * q.r * q.k,
                ii = n * q.i * q.i, ij = n * q.i * q.j, ik = n * q.i * q.k,
                jj = n * q.j * q.j, jk = n * q.j * q.k, kk = n * q.k * q.k;

                return new Matrix<float>(new float[,]
                    {
                        { s.x * (1 - (jj + kk)),       s.y * (ij - rk),       s.z * (ik + rj), t.x },
                        {       s.x * (ij + rk), s.y * (1 - (ii + kk)),       s.z * (jk - ri), t.y },
                        {       s.x * (ik - rj),       s.y * (jk + ri), s.z * (1 - (ii + jj)), t.z },
                        {                     0,                     0,                     0,   1 }
                    }
                );
            }
        }

        class MathDouble : Math<double>
        {
            public override Matrix<double> Matrix(Vector<double> t, Quaternion<double> q, Vector<double> s)
            {
                var n = q.r * q.r + q.i * q.i + q.j * q.j + q.k * q.k;
                if (n != 0) n = 2/n;

                double
                ri = n * q.r * q.i, rj = n * q.r * q.j, rk = n * q.r * q.k,
                ii = n * q.i * q.i, ij = n * q.i * q.j, ik = n * q.i * q.k,
                jj = n * q.j * q.j, jk = n * q.j * q.k, kk = n * q.k * q.k;

                return new Matrix<double>(new double[,]
                    {
                        { s.x * (1 - (jj + kk)),       s.y * (ij - rk),       s.z * (ik + rj), t.x },
                        {       s.x * (ij + rk), s.y * (1 - (ii + kk)),       s.z * (jk - ri), t.y },
                        {       s.x * (ik - rj),       s.y * (jk + ri), s.z * (1 - (ii + jj)), t.z },
                        {                     0,                     0,                     0,   1 }
                    }
                );
            }
        }
    }
}