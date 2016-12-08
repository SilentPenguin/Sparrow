namespace Sparrow.Numerics
{
    public partial struct Vector<T> where T : struct
    {
        abstract class Math<S> where S : struct
        {
            public abstract Vector<S> Add(Vector<S> a, Vector<S> b);
            public abstract Vector<S> Sub(Vector<S> a, Vector<S> b);
            public abstract Vector<S> Mul(Vector<S> a, S b);
            public abstract S Dot(Vector<S> a, Vector<S> b);
            public abstract Vector<S> Cross(Vector<S> a, Vector<S> b);
            public abstract Vector<S> Unit(Vector<S> a);
            public abstract S Magnitude(Vector<S> a);
            public abstract S SquareMagnitude(Vector<S> a);
            public abstract Vector<S> Zeros(int size);
            public abstract Vector<S> Ones(int size);
        }

        class MathFloat : Math<float>
        {
            public override Vector<float> Add(Vector<float> a, Vector<float> b)
            {
                var v = new float[a.Count];
                for(int i = v.Length; i-- != 0;)
                    v[i] = a[i] + b[i];
                return new Vector<float>(v);
            }

            public override Vector<float> Sub(Vector<float> a, Vector<float> b)
            {
                var v = new float[a.Count];
                for(int i = v.Length; i-- != 0;)
                    v[i] = a[i] - b[i];
                return new Vector<float>(v);
            }
            
            public override Vector<float> Mul(Vector<float> a, float b)
            {
                var v = new float[a.Count];
                for(int i = v.Length; i-- != 0;)
                    v[i] *= a[i] * b;
                return new Vector<float>(v);
            }
        
            public override float Dot(Vector<float> a, Vector<float> b)
            {
                float result = 0;
                for (int i = System.Math.Min(a.Count, b.Count); i-- != 0;)
                    result += a[i] * b[i];
                return result;
            }

            public override Vector<float> Cross(Vector<float> v1, Vector<float> v2)
            {
                return new Vector<float>(
                    v1.y * v2.z - v1.z * v2.y,
                    v1.z * v2.x - v1.x * v2.z,
                    v1.x * v2.y - v1.y * v2.x
                );
            }

            public override Vector<float> Unit(Vector<float> a)
            {
                return Mul(a, 1 / Magnitude(a));
            }

            public override float Magnitude(Vector<float> a)
            {
                return (float)System.Math.Sqrt(SquareMagnitude(a));
            }

            public override float SquareMagnitude(Vector<float> a)
            {
                return Dot(a, a);
            }

            public override Vector<float> Zeros(int size)
            {
                var result = new float[size];
                return new Vector<float>(result);
            }

            public override Vector<float> Ones(int size)
            {
                var result = new float[size];
                for(int i = size; i-- != 0;)
                    result[i] = 1;
                return new Vector<float>(result);
            }
        }

        class MathDouble : Math<double>
        {
            public override Vector<double> Add(Vector<double> a, Vector<double> b)
            {
                var v = new double[a.Count];
                for(int i = v.Length; i-- != 0;)
                    v[i] = a[i] + b[i];
                return new Vector<double>(v);
            }

            public override Vector<double> Sub(Vector<double> a, Vector<double> b)
            {
                var v = new double[a.Count];
                for(int i = v.Length; i-- != 0;)
                    v[i] = a[i] - b[i];
                return new Vector<double>(v);
            }
            
            public override Vector<double> Mul(Vector<double> a, double b)
            {
                var v = new double[a.Count];
                for(int i = v.Length; i-- != 0;)
                    v[i] *= a[i] * b;
                return new Vector<double>(v);
            }
        
            public override double Dot(Vector<double> a, Vector<double> b)
            {
                double result = 0;
                for (int i = System.Math.Min(a.Count, b.Count); i-- != 0;)
                    result += a[i] * b[i];
                return result;
            }

            public override Vector<double> Cross(Vector<double> v1, Vector<double> v2)
            {
                return new Vector<double>(
                    v1.y * v2.z - v1.z * v2.y,
                    v1.z * v2.x - v1.x * v2.z,
                    v1.x * v2.y - v1.y * v2.x
                );
            }

            public override Vector<double> Unit(Vector<double> a)
            {
                return Mul(a, 1 / Magnitude(a));
            }

            public override double Magnitude(Vector<double> a)
            {
                return System.Math.Sqrt(SquareMagnitude(a));
            }

            public override double SquareMagnitude(Vector<double> a) {
                return Dot(a, a);
            }

            public override Vector<double> Zeros(int size)
            {
                var result = new double[size];
                return new Vector<double>(result);
            }

            public override Vector<double> Ones(int size)
            {
                var result = new double[size];
                for(int i = size; i-- != 0;)
                    result[i] = 1;
                return new Vector<double>(result);
            }
        }
    }
}