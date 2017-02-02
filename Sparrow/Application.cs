using System;

using Sparrow.Events;
using Sparrow.Inputs;
using Sparrow.Pipelines;
using Sparrow.Sdl2;

using Engine = Sparrow.Engine<Sparrow.FrameState>;

namespace Sparrow
{
    public class Application
    {

        public static Sdl.Window window;
        public static Sdl.Gl.Context context;
        public static Sdl.Renderer renderer;

        public static Engine engine;

        public static InputStateContainer inputStates;

        public static EventPipeline events;
        public static PhysicsPipeline physics;
        public static AnimationPipeline animation;
        public static RenderPipeline rendering;

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
            context = Sdl.Gl.CreateContext(window);
            renderer = Sdl.CreateRenderer(window, flags: Sdl.RendererFlags.Accelerated | Sdl.RendererFlags.TargetTexture);
        }

        public static void CreateEngine()
        {
            // The pipeline processors for our application.
            // These are responsible for consuming frames
            // created by the engine class.
            events = new EventPipeline();
            physics = new PhysicsPipeline();
            animation = new AnimationPipeline();
            rendering = new RenderPipeline();

            events.Subscribe<QuitEvent>(OnQuit);

            var actions = new Action<FrameState>[]
            {
                events.ProcessFrame,
                physics.ProcessFrame,
                animation.ProcessFrame,
                rendering.ProcessFrame
            };

            inputStates = new InputStateContainer();
            events.Subscribe<InputEvent>(inputStates.HandleInput);

            var sequence = new SequentialPipeline(actions);

            // create our engine.
            engine = new Engine();
            engine.action = events.ProcessFrame;
            engine.generator = new FrameGenerator();
        }

        public static void RunEngine()
        {
            engine.Loop();
        }

        public static void OnQuit(QuitEvent evt)
        {
            Sdl.Quit();
            Environment.Exit(0);
        }
    }
}