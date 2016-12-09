using System;

namespace Sparrow.Numerics
{
    public partial struct Matrix<T> where T : struct
    {
        abstract class Math<S> where S : struct
        {
            public abstract Matrix<S> Mul(Matrix<S> a, Matrix<S> b);
            public abstract Vector<S> Mul(Matrix<S> a, Vector<S> b);
            public abstract Matrix<S> Identity(int size);
            public abstract Matrix<S> Empty(int width, int height);
        }
        
        class MathFloat : Math<float>
        {
            public override Matrix<float> Mul(Matrix<float> a, Matrix<float> b)
            {
                if (a.Height != b.Width) throw new ArgumentException();
                var result = new float[a.Width, b.Height];
                for(int i = a.Width; i-- != 0;)
                    for (int j = b.Height; i-- != 0;)
                        result[i, j] = Vector<float>.Dot(a.Row(i), b.Column(j));
                return new Matrix<float>(result);
            }

            public override Vector<float> Mul(Matrix<float> a, Vector<float> b)
            {
                if (a.Width != b.Count) throw new Exception();
                var result = new float[b.Count];
                for (int i = result.Length; i-- != 0;)
                    result[i] = Vector<float>.Dot(a.Row(i), b);
                return new Vector<float>(result);
            }

            public override Matrix<float> Identity(int size)
            {
                var result = new float[size, size];
                for (int i = size; i-- != 0;)
                    result[i, i] = 1;
                return new Matrix<float>(result);
            }

            public override Matrix<float> Empty(int width, int height)
            {
                var result = new float[width, height];
                return new Matrix<float>(result);
            }
        }
        
        class MathDouble : Math<double>
        {
            public override Matrix<double> Mul(Matrix<double> a, Matrix<double> b)
            {
                if (a.Height != b.Width) throw new ArgumentException();
                var result = new double[a.Width, b.Height];
                for(int i = a.Width; i-- != 0;)
                    for (int j = b.Height; i-- != 0;)
                        result[i, j] = Vector<double>.Dot(a.Row(i), b.Column(j));
                return new Matrix<double>(result);
            }
            
            public override Vector<double> Mul(Matrix<double> a, Vector<double> b)
            {
                if (a.Width != b.Count) throw new Exception();
                var result = new double[b.Count];
                for (int i = result.Length; i-- != 0;)
                    result[i] = Vector<double>.Dot(a.Row(i), b);
                return new Vector<double>(result);
            }

            public override Matrix<double> Identity(int size)
            {
                var result = new double[size, size];
                for (int i = size; i-- != 0;)
                    result[i, i] = 1;
                return new Matrix<double>(result);
            }

            public override Matrix<double> Empty(int width, int height)
            {
                var result = new double[width, height];
                return new Matrix<double>(result);
            }
        }
    }
}