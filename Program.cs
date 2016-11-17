using System;
//using Sparrow;
using Sparrow.Reactive;
//using Sparrow.Pipelines;
//using Sparrow.Numerics;

namespace Benchmarks
{
    public class Program : Sparrow.Graphics.OpenGL.Parse.Program
    {

            /*
        public static void Main(string[] args)
        {
            
            Matrix m = new Matrix(new double[,] {{1, 2}, {2, 3}});
            Vector v = m * new Vector(1, 2);
            Console.WriteLine(v);

            //Engine e = new Engine();
            //SequentialPipeline b = new SequentialPipeline(new Action<FrameState>[0]);
            //e.frame.Attach(b.ProcessFrame);

            var test = new Test();
            test.MySender.Send(2);
        }
            */
    }

    public class Test
    {
        public Test()
        {
            MySender = new Sender<float>();
            MyMessenger = new Messenger<float, bool>(MyMessengerAction);
            MyReceiver = new Receiver<bool>(MyReceiverAction);
            MySender.Attach(MyMessenger);
            MyMessenger.Attach(MyReceiver);
        }

        public ISender<float> MySender;
        public IMessenger<float, bool> MyMessenger;
        public IReceiver<bool> MyReceiver;

        public void MySenderAction(int v)
        {
            MySender.Send(v);
        }

        public void MyMessengerAction(float v)
        {
            MyMessenger.Send(v < 3);
        }

        public void MyReceiverAction(bool v)
        {
            Console.WriteLine(v);
        }
    }
}