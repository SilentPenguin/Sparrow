using System;

namespace Sparrow.Numerics
{
    public partial class Transform<T> where T : struct
    {

        public Transform() : this (Vector<T>.Three.Identity(), Quaternion<T>.Identity, Vector<T>.Three.Identity()) {}
        public Transform(Vector<T>.Three translate, Quaternion<T> rotate, Vector<T>.Three scale)
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

        public Vector<T>.Three Translation { get { return t; } set { t = value; m = null; } }
        public Quaternion<T> Rotation { get { return q; } set { q = value; m = null; } }
        public Vector<T>.Three Scale { get { return s; } set { s = value; m = null; } }

        private Vector<T>.Three t;
        private Quaternion<T> q;
        private Vector<T>.Three s;
        private Matrix<T>.Four? m = null;

        public Matrix<T> Transformation
        {
            get
            {
                if (!m.HasValue)
                    m = Matrix(t, q, s);
                return m.Value;
            }
        }

        public static Matrix<T>.Four Matrix(Vector<T>.Three? translate = null, Quaternion<T>? rotate = null, Vector<T>.Three? scale = null)
        {
            var t = translate ?? Vector<T>.Three.Identity();
            var q = rotate ?? Quaternion<T>.Identity;
            var s = scale ?? Vector<T>.Three.Identity();
            return math.Matrix(t, q, s);
        }
    }
}