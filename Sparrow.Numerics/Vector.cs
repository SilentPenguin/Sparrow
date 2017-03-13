using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Sparrow.Numerics
{
    public partial struct Vector<T> : IEnumerable<T> where T : struct
    {
        private readonly T[] items;
        private static readonly Math<T> math;

        public Vector(T x, T y) : this(new T[] {x, y}) {}
        public Vector(T x, T y, T z) : this(new T[] {x, y, z}) {}
        public Vector(T x, T y, T z, T w) : this(new T[] {x, y, z, w}) {}
        public Vector(params T[] items) { this.items = items; }

        static Vector()
        {
            if (typeof(T) == typeof(float))
                math = new MathFloat() as Math<T>;
            else if (typeof(T) == typeof(double))
                math = new MathDouble() as Math<T>;
            if (math == null)
                throw new InvalidOperationException("Type " + typeof(T) + " is not supported by Vector.");
        }

        public T this[int i] { get { return math.Get(items, i); } }
        public int Count { get { return items.Length; } }

        public static T Dot(Vector<T> a, Vector<T> b)
        {
            if (a.Count != b.Count)
            {
                throw new ArithmeticException("Vector dimensions must match");
            }
            return math.Dot(a.items, b.items, a.Count);
        }

        public static Vector<T> Cross(Vector<T> a, Vector<T> b)
        {
            if (a.Count != 3 || b.Count != 3)
            {
                throw new ArithmeticException("Vector dimensions must be 3");
            }
            var result = math.Cross(a.items, b.items, a.Count);
            return new Vector<T>(result);
        }

        public static Vector<T> operator +(Vector<T> a, Vector<T> b)
        {
            if (a.Count != b.Count)
            {
                throw new ArithmeticException("Vector dimensions must match");
            }
            var result = math.Add(a.items, b.items, a.Count);
            return new Vector<T>(result);
        }

        public static Vector<T> operator -(Vector<T> a, Vector<T> b)
        {
            if (a.Count != b.Count)
            {
                throw new ArithmeticException("Vector dimensions must match");
            }
            var result = math.Sub(a.items, b.items, a.Count);
            return new Vector<T>(result);
        }

        public static Vector<T> operator *(Vector<T> a, T b)
        {
            var result = math.Mul(a.items, b, a.Count);
            return new Vector<T>(result);
        }
        public static Vector<T> operator *(T a, Vector<T> b)
        {
            var result = math.Mul(b.items, a, b.Count);
            return new Vector<T>(result);
        }

        public static Vector<T> Identity(int size)
        {
            var result = math.Zeros(size);
            return new Vector<T>(result);
        }

        public Vector<T> Unit
        {
            get
            {
                var result = math.Unit(items, Count);
                return new Vector<T>(result);
            }
        }

        public T Magnitude
        {
            get
            {
                return math.Magnitude(items, Count);
            }
        }

        public T SquareMagnitude
        {
            get
            {
                return math.SquareMagnitude(items, Count);
            }
        }

        public Vector<T> Resize(int size)
        {
            if (Count == size) return this;
            var result = new T[size];
            for (int i = Math.Min(size, Count); i-- != 0;)
                result[i] = this[i];
            return new Vector<T>(result);
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator() { return items.GetEnumerator() as IEnumerator<T>; }
        IEnumerator IEnumerable.GetEnumerator() { return items.GetEnumerator(); }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("Vector<");
            sb.Append(typeof(T));
            sb.Append(">(");
            for(int i = 0; i < this.Count; i++)
            {
                if (i != 0)
                    sb.Append(", ");
                sb.Append(items[i]);
            }
            sb.Append(")");
            return sb.ToString();
        }
    }
}