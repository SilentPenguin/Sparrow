using System;
using System.Text;

namespace Sparrow.Numerics
{
    public struct Quaternion
    {
        public Quaternion(double r, double i, double j, double k) : this(new double[] {r, i, j, k}) {}
        private Quaternion(double[] items) { this.items = items; }

        private double[] items;

        public double r { get { return items[0]; } }
        public double i { get { return items[1]; } }
        public double j { get { return items[2]; } }
        public double k { get { return items[3]; } }

        public static Quaternion Identity { get { return new Quaternion(0, 0, 0, 0); } }
        public Quaternion Conjugate { get { return new Quaternion(r, -i, -j, -k); } }
        public Quaternion Normalised
        {
            get
            {
                double n = Math.Sqrt(i * i + j * j + k * k + r * r);
                return new Quaternion(r / n, i / n, j / n, k / n);
            }
        }

        public static Quaternion operator * (Quaternion q, double s)
        {
            return new Quaternion(q.r * s, q.i * s, q.j * s, q.k * s);
        }

        public static Quaternion operator * (Quaternion q1, Quaternion q2)
        {
            return new Quaternion(
                q1.r * q2.r - q1.i * q2.i - q1.j * q2.j - q1.k * q2.k,
                q1.r * q2.i + q1.i * q2.r + q1.j * q2.k - q1.k * q2.j,
                q1.r * q2.j + q1.j * q2.r + q1.k * q2.i - q1.i * q2.k,
                q1.r * q2.k + q1.k * q2.r + q1.i * q2.j - q1.j * q2.i
            );
        }

        public static Quaternion operator + (Quaternion q1, Quaternion q2)
        {
            return new Quaternion(q1.r + q2.r, q1.i + q2.i, q1.j + q2.j, q1.k + q2.k);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("Quaternion(");
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