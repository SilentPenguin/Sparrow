using System.Runtime.InteropServices;

public static partial class Gl
{
    [DllImport(DllName, EntryPoint = "glGenBuffers")]
    public static extern unsafe GLvoid GenBuffers(GLsizei n, GLuint* buffers);
    [DllImport(DllName, EntryPoint = "glDeleteBuffers")]
    public static extern unsafe GLvoid DeleteBuffers(GLsizei n, GLuint* buffers);
    [DllImport(DllName, EntryPoint = "glBindBuffer")]
    public static extern unsafe GLvoid BindBuffer(GLenum target, GLuint buffer);
    [DllImport(DllName, EntryPoint = "glBindBufferRange")]
    public static extern unsafe GLvoid BindBufferRange(GLenum target, GLuint index, GLuint buffer, GLintptr offset, GLsizeiptr size);
    [DllImport(DllName, EntryPoint = "glBindBufferBase")]
    public static extern unsafe GLvoid BindBufferBase(GLenum target, GLuint index, GLuint buffer);
    [DllImport(DllName, EntryPoint = "glBufferData")]
    public static extern unsafe GLvoid BufferData(GLenum target, GLsizeiptr size, GLvoid* data, GLenum usage);
    [DllImport(DllName, EntryPoint = "glBufferSubData")]
    public static extern unsafe GLvoid BufferSubData(GLenum target, GLintptr offset, GLsizeiptr size, GLvoid* data);
    [DllImport(DllName, EntryPoint = "glMapBufferRange")]
    public static extern unsafe GLvoid MapBufferRange(GLenum target, GLintptr offset, GLsizeiptr length, GLbitfield access);
    [DllImport(DllName, EntryPoint = "glMapBuffer")]
    public static extern unsafe GLvoid MapBuffer(GLenum target, GLenum access);
    [DllImport(DllName, EntryPoint = "glFlushMappedBufferRange")]
    public static extern unsafe GLvoid FlushMappedBufferRange(GLenum target, GLintptr offset, GLsizeiptr length);
    [DllImport(DllName, EntryPoint = "glUnmapBuffer")]
    public static extern unsafe GLvoid UnmapBuffer(GLenum target);
    [DllImport(DllName, EntryPoint = "glCopyBufferSubData")]
    public static extern unsafe GLvoid CopyBufferSubData(GLenum readTarget, GLenum writeTarget, GLintptr readOffset, GLintptr writeOffset, GLsizeiptr size);
    [DllImport(DllName, EntryPoint = "glGenVertexArrays")]
    public static extern unsafe GLvoid GenVertexArrays(GLsizei n, GLuint* arrays);
    [DllImport(DllName, EntryPoint = "glDeleteVertexArrays")]
    public static extern unsafe GLvoid DeleteVertexArrays(GLsizei n, GLuint* arrays);
    [DllImport(DllName, EntryPoint = "glBindVertexArray")]
    public static extern unsafe GLvoid BindVertexArray(GLuint array);
    [DllImport(DllName, EntryPoint = "glIsBuffer")]
    public static extern unsafe GLvoid IsBuffer(GLuint buffer);
    [DllImport(DllName, EntryPoint = "glGetBufferParameteriv")]
    public static extern unsafe GLvoid GetBufferParameter(GLenum target, GLenum pname, GLint* @params);
    [DllImport(DllName, EntryPoint = "glGetBufferSubData")]
    public static extern unsafe GLvoid GetBufferSubData(GLenum target, GLintptr offset, GLsizeiptr size, GLvoid* data);
    [DllImport(DllName, EntryPoint = "glGetBufferPointerv")]
    public static extern unsafe GLvoid GetBufferPointer(GLenum target, GLenum pname, GLvoid** @params);
    [DllImport(DllName, EntryPoint = "glIsVertexArray")]
    public static extern unsafe GLvoid IsVertexArray(GLuint array);
}