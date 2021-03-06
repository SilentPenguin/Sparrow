using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Sparrow.Numerics
{
    public partial struct Quaternion<T> : IEnumerable<T> where T : struct
    {
        public Quaternion(T r, T i, T j, T k) : this(new T[] {r, i, j, k}) {}
        private Quaternion(T[] items) { this.items = items; }

        static Quaternion()
        {
            if (typeof(T) == typeof(float))
                math = new MathFloat() as Math<T>;
            else if (typeof(T) == typeof(double))
                math = new MathDouble() as Math<T>;
            if (math == null)
                throw new InvalidOperationException("Type " + typeof(T) + " is not supported by Quaternion.");
        }

        private readonly T[] items;
        private static readonly Math<T> math;
        
        public T r { get { return items[0]; } }
        public T i { get { return items[1]; } }
        public T j { get { return items[2]; } }
        public T k { get { return items[3]; } }

        public static Quaternion<T> Identity { get { return math.Identity(); } }
        public Quaternion<T> Conjugate { get { return math.Conjugate(this); } }
        public Quaternion<T> Unit { get { return math.Unit(this); } }
        
        public static Quaternion<T> operator * (Quaternion<T> a, T b) { return math.Mul(a, b); }
        public static Quaternion<T> operator * (Quaternion<T> a, Quaternion<T> b) { return math.Mul(a, b); }
        public static Quaternion<T> operator + (Quaternion<T> a, Quaternion<T> b) { return math.Add(a, b); }

        IEnumerator<T> IEnumerable<T>.GetEnumerator() { return items.GetEnumerator() as IEnumerator<T>; }
        IEnumerator IEnumerable.GetEnumerator() { return items.GetEnumerator(); }
        
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("Quaternion<");
            sb.Append(typeof(T));
            sb.Append(">(");
            for(var i = 0; i < items.Length; i++)
            {
                if (i != 0) sb.Append(", ");
                sb.Append(items[i]);
            }
            sb.Append(")");
            return sb.ToString();
        }
    }
}