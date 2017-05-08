using System.Collections;
using System.Collections.Generic;

namespace Sparrow.Numerics
{
    public partial struct Matrix<T> : IEnumerable<T> where T : struct
    {
        private readonly T[,] data;

        public Matrix(T[,] data) => this.data = data;
        public Matrix(T[,][,] patches) => this.data = math.Flatten(patches);

        public T this[int x, int y] { get => data[x, y]; }

        public int Width { get => data.GetLength(0); }
        public int Height { get => data.GetLength(1); }
        public Matrix<T> Transposed { get => new Matrix<T>(math.Transpose(data)); }

        public Vector<T> Column(int x) => new Vector<T>(math.Col(data, x));
        public Vector<T> Row(int y) => new Vector<T>(math.Row(data, y));
        public Matrix<T> Zeros(int size) => new Matrix<T>(math.Zeros(size, size));
        public Matrix<T> Zeros(int width, int height) => new Matrix<T>(math.Zeros(width, height));
        public Matrix<T> Identity(int size) => new Matrix<T>(math.Identity(size, size));

        public static Matrix<T> operator * (Matrix<T> a, Matrix<T> b) => new Matrix<T>(math.Mul(a.data, b.data));
        public static Vector<T> operator * (Matrix<T> a, Vector<T> b) => new Vector<T>(math.Mul(a.data, b));

        public static implicit operator Matrix<T>(T[,] m) => new Matrix<T>(m);
        public static implicit operator T[,]( Matrix<T>m) => m.data.Clone() as T[,];

        public static explicit operator Two(Matrix<T> m) => new Two(math.Resize(m.data, 2, 2));
        public static explicit operator Three(Matrix<T> m) => new Three(math.Resize(m.data, 3, 3));
        public static explicit operator Four(Matrix<T> m) => new Four(math.Resize(m.data, 4, 4));

        IEnumerator<T> IEnumerable<T>.GetEnumerator() => data.GetEnumerator() as IEnumerator<T>;
        IEnumerator IEnumerable.GetEnumerator() => data.GetEnumerator();
    }
}