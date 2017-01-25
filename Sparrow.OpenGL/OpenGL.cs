using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Sparrow.OpenGL
{
    public static class Gl
    {
        private const string DllName = "/System/Library/Frameworks/OpenGL.Framework/OpenGL";

        public enum ErrorType : uint
        {
            NoError                     = 0x0000,
            InvalidEnum                 = 0x0500,
            InvalidValue                = 0x0501,
            InvalidOperation            = 0x0502,
            StackOverflow               = 0x0503,
            StackUnderflow              = 0x0504,
            OutOfMemory                 = 0x0505,
            InvalidFramebufferOperation = 0x0506,
        }

        public enum ShaderType : uint
        {
            FragmentShader = 0x8B30,
            VertexShader = 0x8B31
        }

        public enum VertexAttribPointerType : uint
        {
            Float = 0x1406,
        }

        [Flags]
        public enum ClearBufferMask : uint
        {
            Accum   = 0x00000200,
            Color   = 0x00004000,
            Depth   = 0x00000100,
            Stencil = 0x00000400
        }

        public enum PrimitiveType : uint
        {
            Points                  = 0x0000,
            Lines                   = 0x0001,
            LineLoop                = 0x0002,
            LineStrip               = 0x0003,
            Triangles               = 0x0004,
            TriangleStrip           = 0x0005,
            TriangleFan             = 0x0006,
            Quads                   = 0x0007,
            QuadStrip               = 0x0008,
            Polygon                 = 0x0009,
            /* requires 3.2 */
            LinesAdjacency          = 0x000A,
            LineStripAdjacency      = 0x000B,
            TrianglesAdjacency      = 0x000C,
            TriangleStripAdjacency  = 0x000D,
            /* requires 4.0 */
            Patches                 = 0x000E,
        }

        public enum BufferTarget : uint
        {
            ArrayBuffer             = 0x8892,
            ElementArrayBuffer      = 0x8893,
        }

        public enum BufferUsage : uint
        {
            StreamDraw              = 0x88E0,
            StreamRead              = 0x88E1,
            StreamCopy              = 0x88E2,
            StaticDraw              = 0x88E4,
            StaticRead              = 0x88E5,
            StaticCopy              = 0x88E6,
            DynamicDraw             = 0x88E8,
            DynamicRead             = 0x88E9,
            DynamicCopy             = 0x88EA,
        }

        public enum ShaderParameterType : uint
        {
            ShaderType              = 0x8B4F,
            DeleteStatus            = 0x8B80,
            CompileStatus           = 0x8B81,
            InfoLogLength           = 0x8B84,
            ShaderSourceLength      = 0x8B88,
        }

        public class Shader : SafeHandle
        {
            Shader() : base(IntPtr.Zero, true) {}

            public override bool IsInvalid
            {
                get { return handle.ToInt32() == 0; }
            }

            protected override bool ReleaseHandle()
            {
                DeleteShader(this);
                return true;
            }
        }

        public class Program : SafeHandle
        {
            Program() : base(IntPtr.Zero, true) {}

            public override bool IsInvalid
            {
                get { return handle.ToInt32() == 0; }
            }

            protected override bool ReleaseHandle()
            {
                DeleteProgram(this);
                return true;
            }
        }

        /// <summary>
        /// Return error information.
        /// </summary>
        /// <returns></returns>
        [DllImport(DllName, EntryPoint = "glGetError")]
        public static extern ErrorType GetError();

        /// <summary>
        /// Creates a shader object.
        /// </summary>
        /// <param name="shaderType">Specifies the type of shader to be created.</param>
        /// <returns>This function returns 0 if an error occurs creating the shader object.</returns>
        [DllImport(DllName, EntryPoint = "glCreateShader")]
        public static extern Shader CreateShader(ShaderType shaderType);

        /// <summary>
        /// Replaces the source code in a shader object.
        /// </summary>
        /// <param name="shader">Specifies the handle of the shader object whose source code is to be replaced.</param>
        /// <param name="count">Specifies the number of elements in the string and length arrays.</param>
        /// <param name="source">Specifies an array of pointers to strings containing the source code to be loaded into the shader.</param>
        /// <param name="length">Specifies an array of string lengths.</param>
        [DllImport(DllName, EntryPoint = "glShaderSource")]
        public static extern void ShaderSource(Shader shader, int count, string[] source, int[] length);

        /// <summary>
        /// Deletes a shader object.
        /// </summary>
        /// <param name="shader">Specifies the shader object to be deleted.</param>
        [DllImport(DllName, EntryPoint = "glDeleteShader")]
        public static extern void DeleteShader(Shader shader);

        /// <summary>
        /// Compiles a shader object.
        /// </summary>
        /// <param name="shader">Specifies the shader object to be compiled.</param>
        [DllImport(DllName, EntryPoint = "glCompileShader")]
        public static extern void CompileShader(Shader shader);

        /// <summary>
        /// Creates a program object
        /// </summary>
        /// <returns>This function returns 0 if an error occurs creating the program object.</returns>
        [DllImport(DllName, EntryPoint = "glCreateProgram")]
        public static extern Program CreateProgram();

        /// <summary>
        /// Deletes a program object.
        /// </summary>
        /// <param name="program">Specifies the program object to be deleted.</param>
        [DllImport(DllName, EntryPoint = "glDeleteProgram")]
        public static extern void DeleteProgram(Program program);

        /// <summary>
        /// Attaches a shader object to a program object.
        /// </summary>
        /// <param name="program">Specifies the program object to which a shader object will be attached.</param>
        /// <param name="shader">Specifies the shader object that is to be attached.</param>
        [DllImport(DllName, EntryPoint = "glAttachShader")]
        public static extern void AttachShader(Program program, Shader shader);

        /// <summary>
        /// Links a program object.
        /// </summary>
        /// <param name="program">Specifies the handle of the program object to be linked.</param>
        [DllImport(DllName, EntryPoint = "glLinkProgram")]
        public static extern void LinkProgram(Program program);

        /// <summary>
        /// Installs a program object as part of current rendering state.
        /// </summary>
        /// <param name="program">Specifies the handle of the program object whose executables are to be used as part of current rendering state.</param>
        [DllImport(DllName, EntryPoint = "glUseProgram")]
        public static extern void UseProgram(Program program);

        /// <summary>
        /// Returns the location of an attribute variable.
        /// </summary>
        /// <param name="program">Specifies the program object to be queried.</param>
        /// <param name="name">Points to a null terminated string containing the name of the attribute variable whose location is to be queried.</param>
        /// <returns>If the named attribute variable is not an active attribute in the specified program object or if name starts with the reserved prefix "gl_", a value of -1 is returned.</returns>
        [DllImport(DllName, EntryPoint = "glGetAttribLocation")]
        public static extern int GetAttribLocation(Program program, string name);

        /// <summary>
        /// Enable a generic vertex attribute array.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be enabled.</param>
        [DllImport(DllName, EntryPoint = "glEnableVertexAttribArray")]
        public static extern void EnableVertexAttribArray(uint index);

        /// <summary>
        /// Disable a generic vertex attribute array.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be disabled.</param>
        [DllImport(DllName, EntryPoint = "glDisableVertexAttribArray")]
        public static extern void DisableVertexAttribArray(uint index);

        /// <summary>
        /// Define an array of generic vertex attribute data.
        /// </summary>
        /// <param name="index">Specifies the index of the generic vertex attribute to be modified.</param>
        /// <param name="size">Specifies the number of components per generic vertex attribute. Must be 1, 2, 3, 4.</param>
        /// <param name="type">Specifies the data type of each component in the array.</param>
        /// <param name="normalized">specifies whether fixed-point data values should be normalized or converted directly as fixed-point values when they are accessed.</param>
        /// <param name="stride">Specifies the byte offset between consecutive generic vertex attributes. If stride is 0, the generic vertex attributes are understood to be tightly packed in the array.</param>
        /// <param name="pointer">Specifies a offset of the first component of the first generic vertex attribute in the array in the data store of the buffer currently bound to the GL_ARRAY_BUFFER target.</param>
        [DllImport(DllName, EntryPoint = "glVertexAttribPointer")]
        public static extern void VertexAttribPointer(uint index, int size = 4, VertexAttribPointerType type = VertexAttribPointerType.Float, bool normalized = false, int stride = 0, int pointer = 0);

        /// <summary>
        /// Specify clear values for the color buffers.
        /// </summary>
        /// <param name="red">Specifies the red value used when the color buffers are cleared.</param>
        /// <param name="green">Specifies the green value used when the color buffers are cleared.</param>
        /// <param name="blue">Specifies the blue value used when the color buffers are cleared.</param>
        /// <param name="alpha">Specifies the alpha value used when the color buffers are cleared.</param>
        [DllImport(DllName, EntryPoint = "glClearColor")]
        public static extern void ClearColor(float red = 0, float green = 0, float blue = 0, float alpha = 0);

        /// <summary>
        /// Clear buffers to preset values.
        /// </summary>
        /// <param name="mask">Bitwise OR of masks that indicate the buffers to be cleared.</param>
        [DllImport(DllName, EntryPoint = "glClear")]
        public static extern void Clear(ClearBufferMask mask);

        /// <summary>
        /// Render primitives from array data
        /// </summary>
        /// <param name="mode">Specifies what kind of primitives to render.</param>
        /// <param name="first">Specifies the starting index in the enabled arrays.</param>
        /// <param name="count">Specifies the number of indices to be rendered.</param>
        /// <remarks>
        /// GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP_ADJACENCY and GL_TRIANGLES_ADJACENCY are available only if the GL version is 3.2 or greater.
        /// GL_PATCHES is only available in 4.0
        /// </remarks>
        [DllImport(DllName, EntryPoint = "glDrawArrays")]
        public static extern void DrawArrays(PrimitiveType mode, int first, int count);

        /// <summary>
        /// Generate buffer object names.
        /// </summary>
        /// <param name="n">Specifies the number of buffer object names to be generated.</param>
        /// <param name="buffers">Specifies an array in which the generated buffer object names are stored.</param>
        [DllImport(DllName, EntryPoint = "glGenBuffers")]
        public static extern void GenBuffers(int n, [Out] uint[] buffers);

        /// <summary>
        /// Bind a named buffer object.
        /// </summary>
        /// <param name="target">Specifies the target to which the buffer object is bound.</param>
        /// <param name="buffer">Specifies the name of a buffer object.</param>
        [DllImport(DllName, EntryPoint = "glBindBuffer")]
        public static extern void BindBuffer(BufferTarget target, uint buffer);

        /// <summary>
        /// Creates and initializes a buffer object's data store.
        /// </summary>
        /// <param name="target">Specifies the target to which the buffer object is bound for <see cref="BufferData"/></param>
        /// <param name="size">Specifies the size in bytes of the buffer object's new data store.</param>
        /// <param name="data">Specifies a pointer to data that will be copied into the data store for initialization, or null if no data is to be copied.</param>
        /// <param name="usage">Specifies the expected usage pattern of the data store.</param>
        [DllImport(DllName, EntryPoint = "glBufferData")]
        public static extern void BufferData(BufferTarget target, int size, IntPtr data, BufferUsage usage);

        /// <summary>
        /// Returns a parameter from a shader object.
        /// </summary>
        /// <param name="shader">Specifies the shader object to be queried.</param>
        /// <param name="type">Specifies the object parameter.</param>
        /// <param name="param">Returns the requested object parameter.</param>
        [DllImport(DllName, EntryPoint = "glGetShaderiv")]
        public static extern void GetShader(Shader shader, ShaderParameterType type, out int param);

        /// <summary>
        /// Returns the information log for a shader object.
        /// </summary>
        /// <param name="shader​">Specifies the shader object whose information log is to be queried.</param>
        /// <param name="maxLength​">Specifies the size of the character buffer for storing the returned information log.</param>
        /// <param name="length​">Returns the length of the string returned in infoLog (excluding the null terminator).</param>
        /// <param name="infoLog​">Specifies an array of characters that is used to return the information log.</param>
        [DllImport(DllName, EntryPoint = "glGetShaderInfoLog")]
        public static extern void GetShaderInfoLog(Shader shader​, int maxLength​, out int length​, StringBuilder infoLog​);
    }
}
