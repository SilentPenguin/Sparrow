using System.Runtime.InteropServices;

public static partial class Gl
{
    [DllImport(DllName, EntryPoint = "glEnable")]
    public static extern unsafe GLvoid Enable(GLenum cap);
    [DllImport(DllName, EntryPoint = "glEnablei")]
    public static extern unsafe GLvoid Enable(GLenum target, GLuint index);
    [DllImport(DllName, EntryPoint = "glDisable")]
    public static extern unsafe GLvoid Disable(GLenum cap);
    [DllImport(DllName, EntryPoint = "glDisablei")]
    public static extern unsafe GLvoid Disable(GLenum target, GLuint index);
    [DllImport(DllName, EntryPoint = "glGetError")]
    public static extern unsafe GLvoid GetError();
}