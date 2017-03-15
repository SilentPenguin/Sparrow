using System;

namespace Sparrow.Numerics
{
    public partial struct Vector<T> where T : struct
    {
        private static readonly Math<T> math;

        static Vector()
        {
            if (typeof(T) == typeof(float))
            {
                math = new MathFloat() as Math<T>;
            }
            else if (typeof(T) == typeof(double))
            {
                math = new MathDouble() as Math<T>;
            }
            else
            {
                var message = String.Format("Type {0} is not supported by Vector.", typeof(T));
                throw new InvalidOperationException(message);
            }
        }

        private abstract class Math<S>
        {
            public abstract S[] Add(S[] a, S[] b);
            public abstract S[] Sub(S[] a, S[] b);
            public abstract S[] Mul(S[] a, S b);
            public abstract S Dot(S[] a, S[] b);
            public abstract S[] Cross(S[] a, S[] b);
            public abstract S[] Unit(S[] a);
            public abstract S Magnitude(S[] a);
            public abstract S SquareMagnitude(S[] a);
            public abstract S[] Resize(S[] a, int size);
        }

        private class MathFloat : Math<float>
        {
            public override float[] Add(float[] a, float[] b)
            {
                var v = new float[a.Length];
                for (int i = v.Length; i-- != 0;) v[i] = a[i] + b[i];
                return v;
            }

            public override float[] Sub(float[] a, float[] b)
            {
                var v = new float[a.Length];
                for (int i = v.Length; i-- != 0;) v[i] = a[i] - b[i];
                return v;
            }

            public override float[] Mul(float[] a, float b)
            {
                var v = new float[a.Length];
                for (int i = v.Length; i-- != 0;) v[i] = a[i] * b;
                return v;
            }

            public override float Dot(float[] a, float[] b)
            {
                float result = 0;
                for (int i = a.Length; i-- != 0;) result += a[i] * b[i];
                return result;
            }

            public override float[] Cross(float[] a, float[] b)
            {
                return new float[]
                {
                    a[1] * b[2] - a[2] * b[1],
                    a[2] * b[0] - a[0] * b[2],
                    a[0] * b[1] - a[1] * b[0]
                };
            }

            public override float[] Unit(float[] a)
            {
                return Mul(a, 1 / Magnitude(a));
            }

            public override float Magnitude(float[] a)
            {
                return (float)System.Math.Sqrt(SquareMagnitude(a));
            }

            public override float SquareMagnitude(float[] a)
            {
                return Dot(a, a);
            }

            public override float[] Resize(float[] a, int size)
            {
                var result = new float[size];
                for (int i = size; i-- != 0;) result[i] = i < a.Length ? a[i] : 0;
                return result;
            }
        }

        private class MathDouble : Math<double>
        {
            public override double[] Add(double[] a, double[] b)
            {
                var v = new double[a.Length];
                for (int i = v.Length; i-- != 0;) v[i] = a[i] + b[i];
                return v;
            }

            public override double[] Sub(double[] a, double[] b)
            {
                var v = new double[a.Length];
                for (int i = v.Length; i-- != 0;) v[i] = a[i] - b[i];
                return v;
            }

            public override double[] Mul(double[] a, double b)
            {
                var v = new double[a.Length];
                for (int i = v.Length; i-- != 0;) v[i] = a[i] * b;
                return v;
            }

            public override double Dot(double[] a, double[] b)
            {
                double result = 0;
                for (int i = a.Length; i-- != 0;) result += a[i] * b[i];
                return result;
            }

            public override double[] Cross(double[] a, double[] b)
            {
                return new double[]
                {
                    a[1] * b[2] - a[2] * b[1],
                    a[2] * b[0] - a[0] * b[2],
                    a[0] * b[1] - a[1] * b[0]
                };
            }

            public override double[] Unit(double[] a)
            {
                return Mul(a, 1 / Magnitude(a));
            }

            public override double Magnitude(double[] a)
            {
                return System.Math.Sqrt(SquareMagnitude(a));
            }

            public override double SquareMagnitude(double[] a)
            {
                return Dot(a, a);
            }

            public override double[] Resize(double[] a, int size)
            {
                var result = new double[size];
                for (int i = size; i-- != 0;) result[i] = i < a.Length ? a[i] : 0;
                return result;
            }
        }
    }
}