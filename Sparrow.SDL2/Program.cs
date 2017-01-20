using System;
using System.Threading;

namespace Sparrow.Sdl
{
    public class Program
    {
        public static void Main(string[] args)
        {  
            var s = Sdl.Init();
            s = Sdl.InitSubSystem(Sdl.InitFlag.Video);
            var u = Sdl.WindowPosition.Undefined;
            var f = Sdl.WindowFlags.OpenGL | Sdl.WindowFlags.Shown;
            var w = Sdl.CreateWindow("test", u, u, 640, 480, f);

            if (w == null) {
                var message = Sdl.GetError();
                throw new Exception(message);
            }

            Sdl.Gl.SetAttribute(Sdl.Gl.Attribute.ContextMajorVersion, 2);
            Sdl.Gl.SetAttribute(Sdl.Gl.Attribute.ContextMinorVersion, 0);
            Sdl.Gl.SetSwapInterval(0);
            Sdl.Gl.SetAttribute(Sdl.Gl.Attribute.DoubleBuffer, 1);
            Sdl.Gl.SetAttribute(Sdl.Gl.Attribute.DepthSize, 24);
            var c = Sdl.Gl.CreateContext(w);
            var r = Sdl.CreateRenderer(w, flags: Sdl.RendererFlags.Accelerated | Sdl.RendererFlags.TargetTexture);

            Sdl.Event e;
            while(true)
            {
                while(Sdl.PollEvent(out e) != 0)
                {
                    if (e.type == Sdl.EventType.Quit)
                    {
                        Sdl.Quit();
                        Environment.Exit(0);
                    }
                }

                Thread.Sleep(1);
            }
        }
    }
}