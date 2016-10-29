using System;

namespace Engine.Numerics
{
    public struct Matrix
    {
        private double[,] items;

        public Matrix(double[,] items) { this.items = items; }
        private Matrix(int size) : this(size, size) {}
        private Matrix(int width, int height) : this(new double[width,height]) {}

        public double this[int x, int y]
        {
            get { return items[x, y]; }
            private set { items[x, y] = value; }
        }

        public int Width { get { return items.GetLength(0); } }
        public int Height { get { return items.GetLength(1); } }

        public Matrix Transposition
        {
            get
            {
                var result = new Matrix(Height, Width);
                for (int i = Width; i-- != 0;)
                    for (int j = Height; j-- != 0;)
                        result[j, i] = this[i, j];
                return result;
            }
        }

        public Vector Column(int x)
        {
            var result = new double[x];
            for (int i = items.GetLength(1); i-- != 0;)
                result[i] = this[x, i];
            return new Vector(result);
        }

        public Vector Row(int y)
        {
            var result = new double[y];
            for (int i = items.GetLength(0); i-- != 0;)
                result[i] = this[i, y];
            return new Vector(result);
        }

        public Matrix Empty(int size) { return new Matrix(size); }
        public Matrix Empty(int x, int y) { return new Matrix(x, y); }

        public Matrix Identity(int size)
        {
            var result = new Matrix(size);
            for (int i = size; i-- != 0;)
                result[i,i] = 1;
            return result;
        }

        public static Matrix operator * (Matrix m1, Matrix m2)
        {
            if (m1.Height != m2.Width) throw new Exception();
            var result = new Matrix(m1.Width, m2.Height);
            for(int i = result.Width; i-- != 0;)
                for (int j = result.Height; i-- != 0;)
                    result[i, j] = Vector.Dot(m1.Row(i), m2.Column(j));
            return result;
        }

        public static Vector operator * (Matrix m, Vector v)
        {
            if (v.Count != m.Width) throw new Exception();
            var result = new double[v.Count];
            for (int i = result.Length; i-- != 0;)
                result[i] = Vector.Dot(m.Row(i), v);
            return new Vector(result);
        }
    }
}