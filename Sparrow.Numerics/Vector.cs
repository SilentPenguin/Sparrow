using System.Collections;
using System.Collections.Generic;

namespace Sparrow.Numerics
{
    public partial struct Vector<T> : IEnumerable<T> where T : struct
    {
        internal readonly T[] data;

        public Vector(params T[] data) => this.data = data;
        public Vector(T[][] patches) => this.data = math.Flatten(patches);

        public T this[int i] { get => data[i]; }
        public int Count { get => data.Length; }
        public Vector<T> Unit { get => new Vector<T>(math.Unit(data)); }
        public T Magnitude { get => math.Magnitude(data); }
        public T SquareMagnitude { get => math.SquareMagnitude(data); }

        public static T Dot(Vector<T> a, Vector<T> b) => math.Dot(a.data, b.data);
        public static Vector<T> Cross(Vector<T> a, Vector<T> b) => new Vector<T>(math.Cross(a.data, b.data));
        public static Vector<T> Identity(int size) => new Vector<T>(new T[size]);

        public static Vector<T> operator +(Vector<T> a, Vector<T> b) => new Vector<T>(math.Add(a.data, b.data));
        public static Vector<T> operator -(Vector<T> a, Vector<T> b) => new Vector<T>(math.Sub(a.data, b.data));
        public static Vector<T> operator *(Vector<T> a, T b) => new Vector<T>(math.Mul(a.data, b));
        public static Vector<T> operator *(T a, Vector<T> b) => new Vector<T>(math.Mul(b.data, a));

        public static implicit operator Vector<T>(T[] v) => new Vector<T>(v);
        public static implicit operator T[]( Vector<T> v) => v.data.Clone() as T[];

        public static explicit operator Two(Vector<T> v) => new Two(math.Resize(v.data, 2));
        public static explicit operator Three(Vector<T> v) => new Three(math.Resize(v.data, 3));
        public static explicit operator Four(Vector<T> v) => new Four(math.Resize(v.data, 4));

        IEnumerator<T> IEnumerable<T>.GetEnumerator() => data.GetEnumerator() as IEnumerator<T>;
        IEnumerator IEnumerable.GetEnumerator() => data.GetEnumerator();
    }
}