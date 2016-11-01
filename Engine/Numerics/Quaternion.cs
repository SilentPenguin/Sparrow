using System;
using System.Text;

namespace Engine.Numerics
{
    public struct Quaternion
    {
        public Quaternion(double x, double y, double z, double w) : this(new double[] {x, y, z, w}) {}
        private Quaternion(double[] items) { this.items = items; }

        private double[] items;

        public double x { get { return items[0]; } }
        public double y { get { return items[1]; } }
        public double z { get { return items[2]; } }
        public double w { get { return items[3]; } }

        public Quaternion Conjugate { get { return new Quaternion(-x, -y, -z, w); } }
        public Quaternion Normalised
        {
            get
            {
                double n = Math.Sqrt(x * x + y * y + z * z + w * w);
                return new Quaternion(x / n, y / n, z / n, w / n);
            }
        }

        public static Quaternion operator * (Quaternion q, double s)
        {
            return new Quaternion(q.x * s, q.y * s, q.z * s, q.w * s);
        }

        public static Quaternion operator * (Quaternion q1, Quaternion q2)
        {
            return new Quaternion(
                q1.x * q2.w + q1.y + q2.z - q1.z * q2.y + q1.w * q2.x,
               -q1.x * q2.z + q1.y * q2.w + q1.z * q2.x + q1.w * q2.y,
                q1.x * q2.y - q1.y * q2.x + q1.z * q2.w + q1.w * q2.z,
               -q1.x * q2.x - q1.y * q2.y + q1.z * q2.z + q1.w * q2.w
            );
        }

        public static Quaternion operator + (Quaternion q1, Quaternion q2)
        {
            return new Quaternion(q1.x + q2.x, q1.y + q2.y, q1.z + q2.z, q1.w + q2.w);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("Quaternion(");
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