using System.Runtime.InteropServices;

public static partial class Gl
{
    [DllImport(DllName, EntryPoint = "glDepthRange")]
    public static extern unsafe GLvoid DepthRange(GLdouble near, GLdouble far);
    [DllImport(DllName, EntryPoint = "glViewport")]
    public static extern unsafe GLvoid Viewport(GLint x, GLint y, GLsizei width, GLsizei height);
    [DllImport(DllName, EntryPoint = "glClipPlane")]
    public static extern unsafe GLvoid ClipPlane(GLenum plane, GLdouble* equation);
}