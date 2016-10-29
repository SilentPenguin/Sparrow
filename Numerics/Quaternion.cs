namespace Engine.Numerics
{
    public struct Quaternion
    {
        public float[] items;

        public Quaternion(float x, float y, float z, float w) : this(new float[] {x, y, z, w}) {}
        private Quaternion(float[] items) { this.items = items; }

        public double x { get { return items[0]; } }
        public double y { get { return items[1]; } }
        public double z { get { return items[2]; } }
        public double w { get { return items[3]; } }

    }
}