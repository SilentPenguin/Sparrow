using System.Runtime.InteropServices;

public static partial class Gl
{
    [DllImport(DllName)]
    public static extern unsafe GLvoid DepthRange(GLdouble near, GLdouble far);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Viewport(GLint x, GLint y, GLsizei width, GLsizei height);
    [DllImport(DllName)]
    public static extern unsafe GLvoid ClipPlane(GLenum plane, GLdouble* equation);
}