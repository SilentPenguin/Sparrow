using System.Runtime.InteropServices;

public static partial class Gl
{
    [DllImport(DllName, EntryPoint = "glGenBuffers")]
    public static extern unsafe void GenBuffers(int n, uint* buffers);
    [DllImport(DllName, EntryPoint = "glDeleteBuffers")]
    public static extern unsafe void DeleteBuffers(int n, uint* buffers);
    [DllImport(DllName, EntryPoint = "glBindBuffer")]
    public static extern unsafe void BindBuffer(uint target, uint buffer);
    [DllImport(DllName, EntryPoint = "glBindBufferRange")]
    public static extern unsafe void BindBufferRange(uint target, uint index, uint buffer, int* offset, int* size);
    [DllImport(DllName, EntryPoint = "glBindBufferBase")]
    public static extern unsafe void BindBufferBase(uint target, uint index, uint buffer);
    [DllImport(DllName, EntryPoint = "glBufferData")]
    public static extern unsafe void BufferData(uint target, int* size, void* data, uint usage);
    [DllImport(DllName, EntryPoint = "glBufferSubData")]
    public static extern unsafe void BufferSubData(uint target, int* offset, int* size, void* data);
    [DllImport(DllName, EntryPoint = "glMapBufferRange")]
    public static extern unsafe void MapBufferRange(uint target, int* offset, int* length, uint access);
    [DllImport(DllName, EntryPoint = "glMapBuffer")]
    public static extern unsafe void MapBuffer(uint target, uint access);
    [DllImport(DllName, EntryPoint = "glFlushMappedBufferRange")]
    public static extern unsafe void FlushMappedBufferRange(uint target, int* offset, int* length);
    [DllImport(DllName, EntryPoint = "glUnmapBuffer")]
    public static extern unsafe void UnmapBuffer(uint target);
    [DllImport(DllName, EntryPoint = "glCopyBufferSubData")]
    public static extern unsafe void CopyBufferSubData(uint readTarget, uint writeTarget, int* readOffset, int* writeOffset, int* size);
    [DllImport(DllName, EntryPoint = "glGenVertexArrays")]
    public static extern unsafe void GenVertexArrays(int n, uint* arrays);
    [DllImport(DllName, EntryPoint = "glDeleteVertexArrays")]
    public static extern unsafe void DeleteVertexArrays(int n, uint* arrays);
    [DllImport(DllName, EntryPoint = "glBindVertexArray")]
    public static extern unsafe void BindVertexArray(uint array);
    [DllImport(DllName, EntryPoint = "glIsBuffer")]
    public static extern unsafe void IsBuffer(uint buffer);
    [DllImport(DllName, EntryPoint = "glGetBufferParameteriv")]
    public static extern unsafe void GetBufferParameter(uint target, uint pname, int* @params);
    [DllImport(DllName, EntryPoint = "glGetBufferSubData")]
    public static extern unsafe void GetBufferSubData(uint target, int* offset, int* size, void* data);
    [DllImport(DllName, EntryPoint = "glGetBufferPointerv")]
    public static extern unsafe void GetBufferPointer(uint target, uint pname, void** @params);
    [DllImport(DllName, EntryPoint = "glIsVertexArray")]
    public static extern unsafe void IsVertexArray(uint array);
}