using System.Runtime.InteropServices;

public static partial class Gl
{
    [DllImport(DllName)]
    public static extern unsafe GLvoid GetBoolean(GLenum pname, GLboolean* data);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GetBoolean(GLenum target, GLuint index, GLboolean* data);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GetInteger(GLenum pname, GLint64* data);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GetInteger(GLenum pname, GLint* data);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GetInteger(GLenum target, GLuint index, GLint* data);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GetFloat(GLenum pname, GLfloat* data);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GetDouble(GLenum pname, GLdouble* data);
    [DllImport(DllName)]
    public static extern unsafe GLvoid IsEnabled(GLenum cap);
    [DllImport(DllName)]
    public static extern unsafe GLvoid IsEnabled(GLenum target, GLuint index);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GetPointer(GLenum pname, GLvoid** @params);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GetString(GLenum name);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GetString(GLenum name, GLuint index);
}