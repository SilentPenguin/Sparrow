using System.Runtime.InteropServices;

public static partial class Gl
{
    [DllImport(DllName)]
    public static extern unsafe GLvoid Enable(GLenum cap);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Enable(GLenum target, GLuint index);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Disable(GLenum cap);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Disable(GLenum target, GLuint index);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GetError();
}