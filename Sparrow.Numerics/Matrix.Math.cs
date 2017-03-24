using System;

namespace Sparrow.Numerics
{
    public partial struct Matrix<T> where T : struct
    {
        private static readonly Math<T> math;

        static Matrix()
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

        internal abstract class Math<S> where S : struct
        {
            public abstract S[,] Identity(int x, int y);
            public abstract S[,] Resize(S[,] a, int x, int y);
            public abstract S[,] Zeros(int x, int y);

            public S[,] Mul(S[,] a, S[,] b)
            {
                var width = a.GetLength(0);
                var height = a.GetLength(1);
                var result = new S[width, height];
                for(int i = width; i-- != 0;)
                    for (int j = height; i-- != 0;)
                        result[i, j] = Vector<S>.math.Dot(Row(a, i), Col(a, j));
                return result;
            }

            public S[] Mul(S[,] a, S[] b)
            {
                var length = b.Length;
                var result = new S[length];
                for(int i = length; i-- != 0;)
                        result[i] = Vector<S>.math.Dot(Row(a, i), b);
                return result;
            }

            public S[,] Transpose(S[,] a)
            {
                var width = a.GetLength(0);
                var height = a.GetLength(1);
                var result = new S[height, width];
                for (int i = width; i-- != 0;)
                    for (int j = height; j-- != 0;)
                        result[j, i] = a[i, j];
                return result;
            }

            public S[] Col(S[,] a, int x)
            {
                var height = a.GetLength(1);
                var result = new S[height];
                for (int i = height; i-- != 0;)
                    result[i] = a[x, i];
                return result;
            }
            public S[] Row(S[,] a, int y)
            {
                var width = a.GetLength(0);
                var result = new S[width];
                for (int i = width; i-- != 0;)
                    result[i] = a[i, y];
                return result;
            }
        }

        internal class MathFloat : Math<float>
        {
            public override float[,] Identity(int x, int y)
            {
                var result = new float[x, y];
                for (var i = x; i-- != 0;)
                    for (var j = y; j-- != 0;)
                        result[i, j] = i == j ? 1 : 0;
                return result;
            }

            public override float[,] Resize(float[,] a, int x, int y)
            {
                var width = a.GetLength(0);
                var height = a.GetLength(1);
                var result = new float[x, y];
                for (var i = x; i-- != 0;)
                    for (var j = y; j-- != 0;)
                        result[i, j] = i < width && j < height ? a[i, j] : (i == j ? 1 : 0);
                return result;
            }

            public override float[,] Zeros(int x, int y)
            {
                var result = new float[x, y];
                return result;
            }
        }

        internal class MathDouble : Math<double>
        {
            public override double[,] Identity(int x, int y)
            {
                var result = new double[x, y];
                for (var i = x; i-- != 0;)
                    for (var j = y; j-- != 0;)
                        result[i, j] = i == j ? 1 : 0;
                return result;
            }

            public override double[,] Resize(double[,] a, int x, int y)
            {
                var width = a.GetLength(0);
                var height = a.GetLength(1);
                var result = new double[x, y];
                for (var i = x; i-- != 0;)
                    for (var j = y; j-- != 0;)
                        result[i, j] = i < width && j < height ? a[i, j] : (i == j ? 1 : 0);
                return result;
            }

            public override double[,] Zeros(int x, int y)
            {
                var result = new double[x, y];
                return result;
            }
        }
    }
}