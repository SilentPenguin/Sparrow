using System;
using System.IO;
using System.Runtime.InteropServices;

using Sparrow;
using Sparrow.Events;
using Sparrow.Inputs;
using Sparrow.Pipelines;
using Sparrow.OpenGL;
using Sparrow.Sdl2;

namespace ConsoleApplication
{

    /// <summary>
    /// This is a super basic example to prove that Sparrow runs.
    ///
    /// This uses the Sparrow.OpenGL assembly, this assembly was created
    /// specifically for this example as a wrapper to OpenGL without unmanaged types
    ///
    /// As a result, this example may change in future releases to reflect
    /// adjustments made to Sparrow.
    ///
    /// This example demonstrates how the engine is hookable, and that the pipeline
    /// can be structured differently, or replaced to suit the needs of the game.
    /// </summary>
    public class Program
    {

        static string vertSource = File.ReadAllText("Example.Basic/shader.vert");
        static string fragSource = File.ReadAllText("Example.Basic/shader.frag");

        static Gl.Shader vertShader;
        static Gl.Shader fragShader;
        static Gl.Program program;

        public static void Main(string[] args)
        {
            SetupEnvironment();
            SetupGl();
            SetupPipelines();
            Application.RunEngine();
        }

        public static void SetupEnvironment()
        {
            Application.CreateWindow();
            Application.CreateEngine();
        }

        public static void SetupPipelines()
        {
            Application.events = new EventPipeline();

            var actions = new Action<FrameState>[]
            {
                Application.events.ProcessFrame,
                Tick
            };

            Application.events.Subscribe<QuitEvent>(Application.OnQuit);

            var sequence = new SequentialPipeline(actions);
            Application.engine.action = sequence.ProcessFrame;

            Application.inputStates = new InputStateContainer();
            Application.events.Subscribe<InputDeviceEvent>(Application.inputStates.HandleInput);
        }

        public static void SetupGl()
        {
            // Buffer the data
            uint[] vboArray = new uint[1];
            Gl.GenBuffers(1, vboArray);
            uint vbo = vboArray[0];
            Gl.BindBuffer(Gl.BufferTarget.ArrayBuffer, vbo);
            float[] vertices = {0.0f, 0.5f, 0.45f, -0.5f, -0.45f, -0.5f};
            IntPtr pointer = GCHandle.Alloc(vertices, GCHandleType.Pinned).AddrOfPinnedObject();
            int size = vertices.Length * sizeof(float);
            Gl.BufferData(Gl.BufferTarget.ArrayBuffer, size, pointer, Gl.BufferUsage.StaticDraw);

            // Create shaders
            vertShader = Gl.CreateShader(Gl.ShaderType.VertexShader);
            fragShader = Gl.CreateShader(Gl.ShaderType.FragmentShader);
            Gl.ShaderSource(vertShader, 1, new [] { vertSource }, new [] { vertSource.Length });
            Gl.ShaderSource(fragShader, 1, new [] { fragSource }, new [] { fragSource.Length });
            Gl.CompileShader(vertShader);
            Gl.CompileShader(fragShader);

            // Create Program
            program = Gl.CreateProgram();
            Gl.AttachShader(program, vertShader);
            Gl.AttachShader(program, fragShader);
            Gl.LinkProgram(program);
            Gl.UseProgram(program);

            // Configure the vertex attribute pointer
            var pos = (uint)Gl.GetAttribLocation(program, "position");
            Gl.EnableVertexAttribArray(pos);
            Gl.VertexAttribPointer(pos, size: 2);

            // Set the background colour
            Gl.ClearColor(alpha: 1);
        }

        public static void Tick(FrameState state)
        {
            Gl.Clear(Gl.ClearBufferMask.Color);
            Gl.DrawArrays(Gl.PrimitiveType.Triangles, 0, 3);
            Sdl.Gl.SwapWindow(Application.window);
            /*
            if (Application.inputs.Mouse.Left.IsPressed)
            {
                Console.WriteLine("left mouse button is pressed");
            }
            */
        }
    }
}
