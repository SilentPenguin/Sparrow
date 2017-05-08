using System;

namespace Sparrow.Numerics
{
    public partial struct Vector<T> where T : struct
    {
        abstract class Math<S> where S : struct
        {
            public abstract S Get(S[] a, int i);
            public abstract S[] Add(S[] a, S[] b, int size);
            public abstract S[] Sub(S[] a, S[] b, int size);
            public abstract S[] Mul(S[] a, S b, int size);
            public abstract S Dot(S[] a, S[] b, int size);
            public abstract S[] Cross(S[] a, S[] b, int size);
            public abstract S[] Unit(S[] a, int size);
            public abstract S Magnitude(S[] a, int size);
            public abstract S SquareMagnitude(S[] a, int size);
            public abstract S[] Zeros(int size);
            public abstract S[] Ones(int size);
        }

        class MathFloat : Math<float>
        {
            public override float Get(float[] a, int i)
            {
                return a[i];
            }

            public override float[] Add(float[] a, float[] b, int size)
            {
                var v = new float[size];
                for(int i = v.Length; i-- != 0;)
                    v[i] = a[i] + b[i];
                return v;
            }

            public override float[] Sub(float[] a, float[] b, int size)
            {
                var v = new float[size];
                for(int i = v.Length; i-- != 0;)
                    v[i] = a[i] - b[i];
                return v;
            }

            public override float[] Mul(float[] a, float b, int size)
            {
                var v = new float[size];
                for(int i = v.Length; i-- != 0;)
                    v[i] = a[i] * b;
                return v;
            }

            public override float Dot(float[] a, float[] b, int size)
            {
                float result = 0;
                for (int i = size; i-- != 0;)
                    result += a[i] * b[i];
                return result;
            }

            public override float[] Cross(float[] a, float[] b, int size)
            {
                if (size == 3)
                {
                    return new float[]
                    {
                        a[1] * b[2] - a[2] * b[1],
                        a[2] * b[0] - a[0] * b[2],
                        a[0] * b[1] - a[1] * b[0]
                    };
                }
                else if (size == 7)
                {
                    throw new NotImplementedException();
                }
                else
                {
                    throw new ArgumentException("value must be 3 or 7", "size");
                }
            }

            public override float[] Unit(float[] a, int size)
            {
                return Mul(a, 1 / Magnitude(a, size), size);
            }

            public override float Magnitude(float[] a, int size)
            {
                return (float)System.Math.Sqrt(SquareMagnitude(a, size));
            }

            public override float SquareMagnitude(float[] a, int size)
            {
                return Dot(a, a, size);
            }

            public override float[] Zeros(int size)
            {
                return new float[size];
            }

            public override float[] Ones(int size)
            {
                var result = new float[size];
                for(int i = size; i-- != 0;)
                    result[i] = 1;
                return result;
            }
        }

        class MathDouble : Math<double>
        {
            public override double Get(double[] a, int i)
            {
                return a[i];
            }

            public override double[] Add(double[] a, double[] b, int size)
            {
                var v = new double[size];
                for(int i = v.Length; i-- != 0;)
                    v[i] = a[i] + b[i];
                return v;
            }

            public override double[] Sub(double[] a, double[] b, int size)
            {
                var v = new double[size];
                for(int i = v.Length; i-- != 0;)
                    v[i] = a[i] - b[i];
                return v;
            }

            public override double[] Mul(double[] a, double b, int size)
            {
                var v = new double[size];
                for(int i = v.Length; i-- != 0;)
                    v[i] *= a[i] * b;
                return v;
            }

            public override double Dot(double[] a, double[] b, int size)
            {
                double result = 0;
                for (int i = size; i-- != 0;)
                    result += a[i] * b[i];
                return result;
            }

            public override double[] Cross(double[] a, double[] b, int size)
            {
                if (size == 3)
                {
                    return new double[]
                    {
                        a[1] * b[2] - a[2] * b[1],
                        a[2] * b[0] - a[0] * b[2],
                        a[0] * b[1] - a[1] * b[0]
                    };
                }
                else if (size == 7)
                {
                    throw new NotImplementedException();
                }
                else
                {
                    throw new ArgumentException("value must be 3 or 7", "size");
                }
            }

            public override double[] Unit(double[] a, int size)
            {
                return Mul(a, 1 / Magnitude(a, size), size);
            }

            public override double Magnitude(double[] a, int size)
            {
                return System.Math.Sqrt(SquareMagnitude(a, size));
            }

            public override double SquareMagnitude(double[] a, int size) {
                return Dot(a, a, size);
            }

            public override double[] Zeros(int size)
            {
                return new double[size];
            }

            public override double[] Ones(int size)
            {
                var result = new double[size];
                for(int i = size; i-- != 0;)
                    result[i] = 1;
                return result;
            }
        }
    }
}