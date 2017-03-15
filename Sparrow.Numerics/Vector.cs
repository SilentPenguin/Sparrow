using System;

namespace Sparrow.Numerics
{
    public partial struct Vector<T> where T : struct
    {
        private readonly T[] data;

        public Vector(params T[] data) => this.data = data;

        public T this[int i] { get => data[i]; }
        public int Count { get => data.Length; }
        public Vector<T> Unit { get => new Vector<T>(math.Unit(data)); }
        public T Magnitude { get => math.Magnitude(data); }
        public T SquareMagnitude { get => math.SquareMagnitude(data); }

        public static T Dot(Vector<T> a, Vector<T> b) => math.Dot(a.data, b.data);
        public static Vector<T> Cross(Vector<T> a, Vector<T> b) => new Vector<T>(math.Cross(a.data, b.data));

        public static Vector<T> operator +(Vector<T> a, Vector<T> b) => new Vector<T>(math.Add(a.data, b.data));
        public static Vector<T> operator -(Vector<T> a, Vector<T> b) => new Vector<T>(math.Sub(a.data, b.data));
        public static Vector<T> operator *(Vector<T> a, T b) => new Vector<T>(math.Mul(a.data, b));
        public static Vector<T> operator *(T a, Vector<T> b) => new Vector<T>(math.Mul(b.data, a));

        public static explicit operator Two(Vector<T> v) => new Two(math.Resize(v.data, 2));
        public static explicit operator Three(Vector<T> v) => new Three(math.Resize(v.data, 3));
        public static explicit operator Four(Vector<T> v) => new Four(math.Resize(v.data, 4));
    }
}