using System.Collections;
using System.Collections.Generic;

namespace Sparrow.Numerics
{
    public partial struct Vector<T> : IEnumerable<T>  where T : struct
    {
        public partial struct Two : IEnumerable<T>
        {
            internal readonly T[] data;

            public Two(T x, T y) => this.data = new T[] {x, y};
            internal Two(T[] data) => this.data = data;

            public T this[int i] { get => data[i]; }
            public int Count { get => 2; }
            public Two Unit { get => new Two(math.Unit(data)); }
            public T Magnitude { get => math.Magnitude(data); }
            public T SquareMagnitude { get => math.SquareMagnitude(data); }

            public static T Dot(Two a, Two b) => math.Dot(a.data, b.data);
            public static Two Identity() => new Two(new T[2]);

            public static Two operator +(Two a, Two b) => new Two(math.Add(a.data, b.data));
            public static Two operator -(Two a, Two b) => new Two(math.Sub(a.data, b.data));
            public static Two operator *(Two a, T b) => new Two(math.Mul(a.data, b));
            public static Two operator *(T a, Two b) => new Two(math.Mul(b.data, a));

            public static implicit operator Vector<T>(Two v) => new Vector<T>(v.data);
            public static implicit operator Three(Two v) => new Three(v.x, v.y, default(T));
            public static implicit operator Four(Two v) => new Four(v.x, v.y, default(T), default(T));

            IEnumerator<T> IEnumerable<T>.GetEnumerator() => data.GetEnumerator() as IEnumerator<T>;
            IEnumerator IEnumerable.GetEnumerator() => data.GetEnumerator();
        }

        public partial struct Three : IEnumerable<T>
        {
            internal readonly T[] data;

            public Three(T x, T y, T z) => this.data = new T[] {x, y, z};
            internal Three(T[] data) => this.data = data;

            public T this[int i] { get => data[i]; }
            public int Count { get => 3; }
            public Three Unit { get => new Three(math.Unit(data)); }
            public T Magnitude { get => math.Magnitude(data); }
            public T SquareMagnitude { get => math.SquareMagnitude(data); }

            public static T Dot(Three a, Three b) => math.Dot(a.data, b.data);
            public static Three Cross(Three a, Three b) => new Three(math.Cross(a.data, b.data));
            public static Three Identity() => new Three(new T[3]);

            public static Three operator +(Three a, Three b) => new Three(math.Add(a.data, b.data));
            public static Three operator -(Three a, Three b) => new Three(math.Sub(a.data, b.data));
            public static Three operator *(Three a, T b) => new Three(math.Mul(a.data, b));
            public static Three operator *(T a, Three b) => new Three(math.Mul(b.data, a));

            public static implicit operator Vector<T>(Three v) => new Vector<T>(v.data);
            public static explicit operator Two(Three v) => new Two(v.x, v.y);
            public static implicit operator Four(Three v) => new Four(v.x, v.y, v.z, default(T));

            IEnumerator<T> IEnumerable<T>.GetEnumerator() => data.GetEnumerator() as IEnumerator<T>;
            IEnumerator IEnumerable.GetEnumerator() => data.GetEnumerator();
        }

        public partial struct Four : IEnumerable<T>
        {
            internal readonly T[] data;

            public Four(T x, T y, T z, T w) => this.data = new T[] {x, y, z, w};
            internal Four(T[] data) => this.data = data;

            public T this[int i] { get => data[i]; }
            public int Count { get => 4; }
            public Four Unit { get => new Four(math.Unit(data)); }
            public T Magnitude { get => math.Magnitude(data); }
            public T SquareMagnitude { get => math.SquareMagnitude(data); }

            public static T Dot(Four a, Four b) => math.Dot(a.data, b.data);
            public static Four Identity() => new Four(new T[4]);

            public static Four operator +(Four a, Four b) => new Four(math.Add(a.data, b.data));
            public static Four operator -(Four a, Four b) => new Four(math.Sub(a.data, b.data));
            public static Four operator *(Four a, T b) => new Four(math.Mul(a.data, b));
            public static Four operator *(T a, Four b) => new Four(math.Mul(b.data, a));

            public static implicit operator Vector<T>(Four v) => new Vector<T>(v.data);
            public static explicit operator Two(Four v) => new Two(v.x, v.y);
            public static explicit operator Three(Four v) => new Three(v.x, v.y, v.z);

            IEnumerator<T> IEnumerable<T>.GetEnumerator() => data.GetEnumerator() as IEnumerator<T>;
            IEnumerator IEnumerable.GetEnumerator() => data.GetEnumerator();
        }
    }
}