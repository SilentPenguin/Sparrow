using System.Runtime.InteropServices;

public static partial class Gl
{
    [DllImport(DllName)]
    public static extern unsafe GLvoid Fog(GLenum pname, GLfloat param);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Fog(GLenum pname, GLfloat* @params);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Fog(GLenum pname, GLint param);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Fog(GLenum pname, GLint* @params);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Hint(GLenum target, GLenum mode);
}