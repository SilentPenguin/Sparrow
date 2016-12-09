using System.Runtime.InteropServices;

public static partial class Gl
{
    [DllImport(DllName, EntryPoint = "glGetBooleanv")]
    public static extern unsafe GLvoid GetBoolean(GLenum pname, GLboolean* data);
    [DllImport(DllName, EntryPoint = "glGetBooleani_v")]
    public static extern unsafe GLvoid GetBoolean(GLenum target, GLuint index, GLboolean* data);
    [DllImport(DllName, EntryPoint = "glGetInteger64v")]
    public static extern unsafe GLvoid GetInteger(GLenum pname, GLint64* data);
    [DllImport(DllName, EntryPoint = "glGetIntegerv")]
    public static extern unsafe GLvoid GetInteger(GLenum pname, GLint* data);
    [DllImport(DllName, EntryPoint = "glGetIntegeri_v")]
    public static extern unsafe GLvoid GetInteger(GLenum target, GLuint index, GLint* data);
    [DllImport(DllName, EntryPoint = "glGetFloatv")]
    public static extern unsafe GLvoid GetFloat(GLenum pname, GLfloat* data);
    [DllImport(DllName, EntryPoint = "glGetDoublev")]
    public static extern unsafe GLvoid GetDouble(GLenum pname, GLdouble* data);
    [DllImport(DllName, EntryPoint = "glIsEnabled")]
    public static extern unsafe GLvoid IsEnabled(GLenum cap);
    [DllImport(DllName, EntryPoint = "glIsEnabledi")]
    public static extern unsafe GLvoid IsEnabled(GLenum target, GLuint index);
    [DllImport(DllName, EntryPoint = "glGetPointerv")]
    public static extern unsafe GLvoid GetPointer(GLenum pname, GLvoid** @params);
    [DllImport(DllName, EntryPoint = "glGetString")]
    public static extern unsafe GLvoid GetString(GLenum name);
    [DllImport(DllName, EntryPoint = "glGetStringi")]
    public static extern unsafe GLvoid GetString(GLenum name, GLuint index);
}