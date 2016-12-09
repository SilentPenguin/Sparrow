using System.Runtime.InteropServices;

public static partial class Gl
{
    [DllImport(DllName)]
    public static extern unsafe GLvoid ReadPixels(GLint x, GLint y, GLsizei width, GLsizei height, GLenum format, GLenum type, GLvoid* pixels);
    [DllImport(DllName)]
    public static extern unsafe GLvoid ReadBuffer(GLenum src);
    [DllImport(DllName)]
    public static extern unsafe GLvoid CopyPixels(GLint x, GLint y, GLsizei width, GLsizei height, GLenum type);
    [DllImport(DllName)]
    public static extern unsafe GLvoid BlitFramebuffer(GLint srcX0, GLint srcY0, GLint srcX1, GLint srcY1, GLint dstX0, GLint dstY0, GLint dstX1, GLint dstY1, GLbitfield mask, GLenum filter);
}