using System;
using Sparrow.Pipelines;
using Sparrow.Inputs;
using Sparrow.Sdl2;
using Engine = Sparrow.Engine<Sparrow.FrameState>;

namespace Sparrow
{
    public class Application
    {

        public static Sdl.Window window;
        public static Engine engine;

        public static void Main(string[] args)
        {
            CreateWindow();
            CreateEngine();
            RunEngine();
        }

        public static void CreateWindow()
        {
            // initialise SDL and create a window
            var s = Sdl.Init();
            s = Sdl.InitSubSystem(Sdl.InitFlag.Video);
            var u = Sdl.WindowPosition.Undefined;
            var f = Sdl.WindowFlags.OpenGL | Sdl.WindowFlags.Shown;
            window = Sdl.CreateWindow("Application", u, u, 640, 480, f);

            if (window == null) {
                var message = Sdl.GetError();
                throw new Exception(message);
            }

            // Create a GL rendering context
            Sdl.Gl.SetAttribute(Sdl.Gl.Attribute.ContextMajorVersion, 2);
            Sdl.Gl.SetAttribute(Sdl.Gl.Attribute.ContextMinorVersion, 0);
            Sdl.Gl.SetSwapInterval(Sdl.Gl.SwapInterval.Immediate);
            Sdl.Gl.SetAttribute(Sdl.Gl.Attribute.DoubleBuffer, 1);
            Sdl.Gl.SetAttribute(Sdl.Gl.Attribute.DepthSize, 24);
            var c = Sdl.Gl.CreateContext(window);
            var r = Sdl.CreateRenderer(window, flags: Sdl.RendererFlags.Accelerated | Sdl.RendererFlags.TargetTexture);
        }

        public static void CreateEngine()
        {
            // The pipeline processors for our application.
            // These are responsible for consuming frames
            // created by the engine class.
            var inputs = new InputsPipeline();
            var physics = new PhysicsPipeline();
            var animation = new AnimationPipeline();
            var render = new RenderPipeline();

            var actions = new Action<FrameState>[]
            {
                inputs.ProcessFrame,
                physics.ProcessFrame,
                animation.ProcessFrame,
                render.ProcessFrame
            };

            var sequence = new SequentialPipeline(actions);

            // create our engine.
            engine = new Engine();
            engine.action = inputs.ProcessFrame;
            engine.generator = new FrameGenerator();
        }

        public static void RunEngine()
        {
            engine.Loop();
        }
    }
}