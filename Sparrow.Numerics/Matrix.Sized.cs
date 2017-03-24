using System.Collections;
using System.Collections.Generic;

namespace Sparrow.Numerics
{
    public partial struct Matrix<T> : IEnumerable<T> where T : struct
    {
        public partial struct Two : IEnumerable<T>
        {
            internal readonly T[,] data;

            public Two(T x0y0, T x1y0, T x0y1, T x1y1) => data = new T [2,2] {{x0y0, x1y0}, {x1y0, x1y1}};
            internal Two(T[,] data) => this.data = data;

            public T this[int x, int y] { get => data[x, y]; }

            public int Width { get => 2; }
            public int Height { get => 2; }
            public Two Transposed { get => new Two(math.Transpose(data)); }

            public Vector<T>.Two Column(int x) => new Vector<T>.Two(math.Col(data, x));
            public Vector<T>.Two Row(int y) => new Vector<T>.Two(math.Row(data, y));
            public Two Zeros() => new Two(math.Zeros(2, 2));
            public Two Identity() => new Two(math.Identity(2, 2));

            public static Two operator * (Two a, Two b) => new Two(math.Mul(a.data, b.data));
            public static Vector<T>.Two operator * (Two a, Vector<T>.Two b) => new Vector<T>.Two(math.Mul(a.data, b.data));

            public static implicit operator Matrix<T>(Two m) => new Matrix<T>(m.data);
            public static explicit operator Three(Two m) => new Three(math.Resize(m.data, 3,3));
            public static implicit operator Four(Two m) => new Four(math.Resize(m.data, 4,4));

            IEnumerator<T> IEnumerable<T>.GetEnumerator() => data.GetEnumerator() as IEnumerator<T>;
            IEnumerator IEnumerable.GetEnumerator() => data.GetEnumerator();
        }

        public partial struct Three : IEnumerable<T>
        {
            internal readonly T[,] data;

            public Three(T x0y0, T x1y0, T x2y0, T x0y1, T x1y1, T x2y1, T x0y2, T x1y2, T x2y2) => data = new T [3,3] {{x0y0, x1y0, x2y0}, {x0y1, x1y1, x2y1}, {x0y2, x1y2, x2y2}};
            internal Three(T[,] data) => this.data = data;

            public T this[int x, int y] { get => data[x, y]; }

            public int Width { get => 3; }
            public int Height { get => 3; }
            public Three Transposed { get => new Three(math.Transpose(data)); }

            public Vector<T>.Three Column(int x) => new Vector<T>.Three(math.Col(data, x));
            public Vector<T>.Three Row(int y) => new Vector<T>.Three(math.Row(data, y));
            public Three Zeros() => new Three(math.Zeros(3, 3));
            public Three Identity() => new Three(math.Identity(3, 3));

            public static Three operator * (Three a, Three b) => new Three(math.Mul(a.data, b.data));
            public static Vector<T>.Three operator * (Three a, Vector<T>.Three b) => new Vector<T>.Three(math.Mul(a.data, b.data));

            public static implicit operator Matrix<T>(Three m) => new Matrix<T>(m.data);
            public static explicit operator Two(Three m) => new Two(math.Resize(m.data, 2,2));
            public static implicit operator Four(Three m) => new Four(math.Resize(m.data, 4,4));

            IEnumerator<T> IEnumerable<T>.GetEnumerator() => data.GetEnumerator() as IEnumerator<T>;
            IEnumerator IEnumerable.GetEnumerator() => data.GetEnumerator();
        }

        public partial struct Four : IEnumerable<T>
        {
            internal readonly T[,] data;

            public Four(T x0y0, T x1y0, T x2y0, T x3y0, T x0y1, T x1y1, T x2y1, T x3y1, T x0y2, T x1y2, T x2y2, T x3y2, T x0y3, T x1y3, T x2y3, T x3y3) => data = new T [4,4] {{x0y0, x1y0, x2y0, x3y0}, {x0y1, x1y1, x2y1, x3y1}, {x0y2, x1y2, x2y2, x3y2}, {x0y3, x1y3, x2y3, x3y3}};
            internal Four(T[,] data) => this.data = data;

            public T this[int x, int y] { get => data[x, y]; }

            public int Width { get => 4; }
            public int Height { get => 4; }
            public Four Transposed { get => new Four(math.Transpose(data)); }

            public Vector<T>.Four Column(int x) => new Vector<T>.Four(math.Col(data, x));
            public Vector<T>.Four Row(int y) => new Vector<T>.Four(math.Row(data, y));
            public Four Zeros() => new Four(math.Zeros(4, 4));
            public Four Identity() => new Four(math.Identity(4, 4));

            public static Four operator * (Four a, Four b) => new Four(math.Mul(a.data, b.data));
            public static Vector<T>.Four operator * (Four a, Vector<T>.Four b) => new Vector<T>.Four(math.Mul(a.data, b.data));

            public static implicit operator Matrix<T>(Four m) => new Matrix<T>(m.data);
            public static explicit operator Two(Four m) => new Two(math.Resize(m.data, 2, 2));
            public static implicit operator Three(Four m) => new Three(math.Resize(m.data, 3, 3));

            IEnumerator<T> IEnumerable<T>.GetEnumerator() => data.GetEnumerator() as IEnumerator<T>;
            IEnumerator IEnumerable.GetEnumerator() => data.GetEnumerator();

        }
    }
}