using System;

namespace Sparrow.Numerics
{
    public partial class Transform<T> where T : struct
    {

        public Transform() : this (Vector<T>.Identity(3), Quaternion<T>.Identity, Vector<T>.Identity(3)) {}
        public Transform(Vector<T> translate, Quaternion<T> rotate, Vector<T> scale)
        {
            t = translate;
            q = rotate;
            s = scale;
        }

        static Transform()
        {
            if (typeof(T) == typeof(float))
                math = new MathFloat() as Math<T>;
            if (typeof(T) == typeof(double))
                math = new MathDouble() as Math<T>;
            if (math == null)
                throw new InvalidOperationException("Type " + typeof(T) + " is not supported by Transform.");
        }

        private static Math<T> math;

        public Vector<T> Translation { get { return t; } set { t = value; m = null; } }
        public Quaternion<T> Rotation { get { return q; } set { q = value; m = null; } }
        public Vector<T> Scale { get { return s; } set { s = value; m = null; } }

        private Vector<T> t;
        private Quaternion<T> q;
        private Vector<T> s;
        private Matrix<T>? m = null;

        public Matrix<T> Transformation
        {
            get
            {
                if (!m.HasValue)
                    m = Matrix(t, q, s);
                return m.Value;
            }
        }

        public static Matrix<T> Matrix(Vector<T>? translate = null, Quaternion<T>? rotate = null, Vector<T>? scale = null)
        {
            var t = translate ?? Vector<T>.Identity(3);
            var q = rotate ?? Quaternion<T>.Identity;
            var s = scale ?? Vector<T>.Identity(3);
            return math.Matrix(t, q, s);
        }
    }
}