using System.Runtime.InteropServices;

public static partial class Gl
{
    [DllImport(DllName, EntryPoint = "glFogf")]
    public static extern unsafe GLvoid Fog(GLenum pname, GLfloat param);
    [DllImport(DllName, EntryPoint = "glFogfv")]
    public static extern unsafe GLvoid Fog(GLenum pname, GLfloat* @params);
    [DllImport(DllName, EntryPoint = "glFogi")]
    public static extern unsafe GLvoid Fog(GLenum pname, GLint param);
    [DllImport(DllName, EntryPoint = "glFogiv")]
    public static extern unsafe GLvoid Fog(GLenum pname, GLint* @params);
    [DllImport(DllName, EntryPoint = "glHint")]
    public static extern unsafe GLvoid Hint(GLenum target, GLenum mode);
}