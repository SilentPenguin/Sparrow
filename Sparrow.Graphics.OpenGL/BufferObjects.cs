using System.Runtime.InteropServices;

public static partial class Gl
{
    [DllImport(DllName)]
    public static extern unsafe GLvoid GenBuffers(GLsizei n, GLuint* buffers);
    [DllImport(DllName)]
    public static extern unsafe GLvoid DeleteBuffers(GLsizei n, GLuint* buffers);
    [DllImport(DllName)]
    public static extern unsafe GLvoid BindBuffer(GLenum target, GLuint buffer);
    [DllImport(DllName)]
    public static extern unsafe GLvoid BindBufferRange(GLenum target, GLuint index, GLuint buffer, GLintptr offset, GLsizeiptr size);
    [DllImport(DllName)]
    public static extern unsafe GLvoid BindBufferBase(GLenum target, GLuint index, GLuint buffer);
    [DllImport(DllName)]
    public static extern unsafe GLvoid BufferData(GLenum target, GLsizeiptr size, GLvoid* data, GLenum usage);
    [DllImport(DllName)]
    public static extern unsafe GLvoid BufferSubData(GLenum target, GLintptr offset, GLsizeiptr size, GLvoid* data);
    [DllImport(DllName)]
    public static extern unsafe GLvoid MapBufferRange(GLenum target, GLintptr offset, GLsizeiptr length, GLbitfield access);
    [DllImport(DllName)]
    public static extern unsafe GLvoid MapBuffer(GLenum target, GLenum access);
    [DllImport(DllName)]
    public static extern unsafe GLvoid FlushMappedBufferRange(GLenum target, GLintptr offset, GLsizeiptr length);
    [DllImport(DllName)]
    public static extern unsafe GLvoid UnmapBuffer(GLenum target);
    [DllImport(DllName)]
    public static extern unsafe GLvoid CopyBufferSubData(GLenum readTarget, GLenum writeTarget, GLintptr readOffset, GLintptr writeOffset, GLsizeiptr size);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GenVertexArrays(GLsizei n, GLuint* arrays);
    [DllImport(DllName)]
    public static extern unsafe GLvoid DeleteVertexArrays(GLsizei n, GLuint* arrays);
    [DllImport(DllName)]
    public static extern unsafe GLvoid BindVertexArray(GLuint array);
    [DllImport(DllName)]
    public static extern unsafe GLvoid IsBuffer(GLuint buffer);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GetBufferParameter(GLenum target, GLenum pname, GLint* @params);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GetBufferSubData(GLenum target, GLintptr offset, GLsizeiptr size, GLvoid* data);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GetBufferPointer(GLenum target, GLenum pname, GLvoid** @params);
    [DllImport(DllName)]
    public static extern unsafe GLvoid IsVertexArray(GLuint array);
}