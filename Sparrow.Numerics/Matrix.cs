using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Sparrow.Numerics
{
    public partial struct Matrix<T> : IEnumerable<T> where T : struct
    {
        public Matrix(T[,] items) { this.items = items; }

        static Matrix()
        {
            if (typeof(T) == typeof(float))
                math = new MathFloat() as Math<T>;
            else if (typeof(T) == typeof(double))
                math = new MathDouble() as Math<T>;
            if(math == null)
                throw new InvalidOperationException("Type " + typeof(T) + " is not supported by Matrix.");
        }

        private readonly T[,] items;
        private static readonly Math<T> math;

        public T this[int x, int y] { get { return math.Get(this, x, y); } }

        public int Width { get { return items.GetLength(0); } }
        public int Height { get { return items.GetLength(1); } }
        
        public Vector<T> Column(int x)
        {
            var result = new T[Height];
            for (int i = Height; i-- != 0;)
                result[i] = items[x, i];
            return new Vector<T>(result);
        }

        public Vector<T> Row(int y)
        {
            var result = new T[Width];
            for (int i = Width; i-- != 0;)
                result[i] = items[i, y];
            return new Vector<T>(result);
        }

        public Matrix<T> Transposed
        {
            get
            {
                var result = new T[Height, Width];
                for (int i = Width; i-- != 0;)
                    for (int j = Height; j-- != 0;)
                        result[j, i] = this[i, j];
                return new Matrix<T>(result);
            }
        }

        public static Matrix<T> Identity() { return new Matrix<T>(); }
        public static Matrix<T> Empty(int size) { return math.Empty(size, size); }
        public static Matrix<T> Empty(int width, int height) { return math.Empty(width, height); }
        public static Matrix<T> operator * (Matrix<T> a, Matrix<T> b) { return math.Mul(a, b); }
        public static Vector<T> operator * (Matrix<T> a, Vector<T> b) { return math.Mul(a, b); }
        
        public Matrix<T> Resize(int size) { return Resize(size, size); }
        public Matrix<T> Resize(int width, int height)
        {
            if (width == Width && height == Height) return this;
            var result = new T[width, height];
            for (var i = Math.Min(width, Width); i-- != 0;)
                for (var j = Math.Min(height, Height); j-- != 0;)
                    result[i, j] = items[i, j];
            return new Matrix<T>(result);
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator() { return items.GetEnumerator() as IEnumerator<T>; }
        IEnumerator IEnumerable.GetEnumerator() { return items.GetEnumerator(); }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("Matrix<");
            sb.Append(typeof(T));
            sb.Append(">(");
            for(int i = 0; i < this.Width; i++)
            {
                for (int j = 0; j < this.Height; j++)
                {
                    if (j != 0) sb.Append(", ");
                    sb.Append(items[i, j]);
                }
                sb.Append("; ");
            }
            sb.Append(")");
            return sb.ToString();
        }
    }
}