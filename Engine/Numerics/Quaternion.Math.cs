namespace Sparrow.Numerics
{
    public partial struct Quaternion<T> where T : struct
    {
        abstract class Math<S> where S : struct
        {
            public abstract Quaternion<S> Identity();
            public abstract Quaternion<S> Conjugate(Quaternion<S> a);
            public abstract Quaternion<S> Unit(Quaternion<S> a);
            public abstract Quaternion<S> Mul(Quaternion<S> a, S b);
            public abstract Quaternion<S> Mul(Quaternion<S> a, Quaternion<S> b);
            public abstract Quaternion<S> Add(Quaternion<S> a, Quaternion<S> b);
        }

        class MathFloat : Math<float>
        {
            public override Quaternion<float> Identity()
            {
                return new Quaternion<float>(0, 0, 0, 0);
            }

            public override Quaternion<float> Conjugate(Quaternion<float> a)
            {
                return new Quaternion<float>(a.r, -a.i, -a.j, -a.k);
            }

            public override Quaternion<float> Unit(Quaternion<float> a)
            {
                float n = (float)System.Math.Sqrt(a.i * a.i + a.j * a.j + a.k * a.k + a.r * a.r);
                return new Quaternion<float>(a.r / n, a.i / n, a.j / n, a.k / n);
            }

            public override Quaternion<float> Mul(Quaternion<float> a, float b)
            {
                return new Quaternion<float>(a.r * b, a.i * b, a.j * b, a.k * b);
            }

            public override Quaternion<float> Mul(Quaternion<float> a, Quaternion<float> b)
            {
                return new Quaternion<float>
                (
                    a.r * b.r - a.i * b.i - a.j * b.j - a.k * b.k,
                    a.r * b.i + a.i * b.r + a.j * b.k - a.k * b.j,
                    a.r * b.j + a.j * b.r + a.k * b.i - a.i * b.k,
                    a.r * b.k + a.k * b.r + a.i * b.j - a.j * b.i
                );
            }

            public override Quaternion<float> Add(Quaternion<float> a, Quaternion<float> b)
            {
                return new Quaternion<float>(a.r + b.r, a.i + b.i, a.j + b.j, a.k + b.k);
            }
        }

        class MathDouble : Math<double>
        {
            public override Quaternion<double> Identity()
            {
                return new Quaternion<double>(0, 0, 0, 0);
            }

            public override Quaternion<double> Conjugate(Quaternion<double> a)
            {
                return new Quaternion<double>(a.r, -a.i, -a.j, -a.k);
            }

            public override Quaternion<double> Unit(Quaternion<double> a)
            {
                double n = System.Math.Sqrt(a.i * a.i + a.j * a.j + a.k * a.k + a.r * a.r);
                return new Quaternion<double>(a.r / n, a.i / n, a.j / n, a.k / n);
            }

            public override Quaternion<double> Mul(Quaternion<double> a, double b)
            {
                return new Quaternion<double>(a.r * b, a.i * b, a.j * b, a.k * b);
            }

            public override Quaternion<double> Mul(Quaternion<double> a, Quaternion<double> b)
            {
                return new Quaternion<double>
                (
                    a.r * b.r - a.i * b.i - a.j * b.j - a.k * b.k,
                    a.r * b.i + a.i * b.r + a.j * b.k - a.k * b.j,
                    a.r * b.j + a.j * b.r + a.k * b.i - a.i * b.k,
                    a.r * b.k + a.k * b.r + a.i * b.j - a.j * b.i
                );
            }

            public override Quaternion<double> Add(Quaternion<double> a, Quaternion<double> b)
            {
                return new Quaternion<double>(a.r + b.r, a.i + b.i, a.j + b.j, a.k + b.k);
            }
        }
    }
}