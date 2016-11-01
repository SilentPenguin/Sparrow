using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Text;

namespace Sparrow.Numerics
{
    public struct Vector : IEnumerable
    {
        public Vector(double x, double y) : this (new double[] {x, y}) {}
        public Vector(double x, double y, double z) : this(new double[] {x, y, z}) {}
        public Vector(double x, double y, double z, double w) : this(new double[] {x, y, z, w}) {}
        public Vector(params double[] items) { this.items = items; }
        private Vector(int size) : this(new double[size]) {}
        
        private double[] items;

        public double x { get { return items[0]; } }
        public double y { get { return items[1]; } }
        public double z { get { return items[2]; } }
        public double w { get { return items[3]; } }

        public double this[int i]
        {
            get { return items[i]; }
            private set { items[i] = value; }
        }

        public int Count { get { return items.Length; } }
        public Vector Unit { get { return 1 / Magnitude * this; } }
        public double Magnitude { get { return Math.Sqrt(SqrMagnitude); } }
        public double SqrMagnitude { get { return Vector.Dot(this, this); } }

        public Vector Resize(int size)
        {
            if (Count == size) return this;
            var result = new Vector(size);
            for (int i = Math.Min(size, Count); i-- != 0;)
                result[i] = this[i];
            return result;
        }

        public IEnumerator GetEnumerator()
        {
            return items.GetEnumerator();
        }

        public static double Dot(Vector v1, Vector v2)
        {
            double result = 0;
            for (int i = Math.Min(v1.Count, v2.Count); i-- != 0;)
                result += v1[i] * v2[i];
            return result;
        }

        public static Vector Cross(Vector v1, Vector v2)
        {
            return new Vector(
                v1.y * v2.z - v1.z * v2.y,
                v1.z * v2.x - v1.x * v2.z,
                v1.x * v2.y - v1.y * v2.x
            );
        }

        public static Vector Zeros(int size) { return new Vector(size); }
        public static Vector Ones(int size) { return Action(new Vector(size), (i) => 1); }

        // Vector Math Operators
        public static Vector operator + (Vector v1, Vector v2) { return Binary(v1, v2, (a, b) => a + b); }
        public static Vector operator - (Vector v1, Vector v2) { return Binary(v1, v2, (a, b) => a - b); }
        public static Vector operator + (double s, Vector v) { return Unary(v, (vi) => vi); }
        public static Vector operator - (double s, Vector v) { return Unary(v, (vi) => -vi); }
        public static Vector operator * (double s, Vector v) { return Unary(v, (vi) => s * vi); }

        // Perform a Unary operation on each element, using a function to transform one vector into another vector.
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Vector Unary(Vector v, Func<double, double> func)
        {
            return Action(new Vector(v.Count), i => func(v[i]));
        }

        // Perform a Binary operation on each element, using a function to transform two vectors into another vector.
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Vector Binary(Vector v1, Vector v2, Func<double, double, double> func)
        {
            if (v1.Count < v2.Count) v1 = v1.Resize(v2.Count);
            else if (v2.Count < v1.Count) v2 = v2.Resize(v1.Count);
            return Action(new Vector(v1.Count), i => func(v1[i], v2[i]));
        }

        // Perform an action on a vector
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Vector Action(Vector v, Func<int, double> func)
        {
            for (int i = v.Count; i-- != 0;)
                v[i] = func(i);
            return v;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("Vector(");
            for(var i = 0; i < items.Length; i++)
            {
                if (i != 0) sb.Append(", ");
                sb.Append(i);
            }
            sb.Append(")");
            return sb.ToString();
        }
    }
}