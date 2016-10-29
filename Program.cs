using System;
using Engine.Numerics;

namespace Benchmarks
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Matrix m = new Matrix(new double[,] {{1, 2}, {2, 3}});
            Vector v = m * new Vector(1, 2);
            Console.WriteLine(v);
            Console.ReadLine();
        }
    }
}