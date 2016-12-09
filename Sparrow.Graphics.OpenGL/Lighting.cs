using System.Runtime.InteropServices;

public static partial class Gl
{
    [DllImport(DllName)]
    public static extern unsafe GLvoid Material(GLenum face, GLenum pname, GLfloat param);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Material(GLenum face, GLenum pname, GLfloat* @params);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Material(GLenum face, GLenum pname, GLint param);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Material(GLenum face, GLenum pname, GLint* @params);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Light(GLenum light, GLenum pname, GLfloat param);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Light(GLenum light, GLenum pname, GLfloat* @params);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Light(GLenum light, GLenum pname, GLint param);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Light(GLenum light, GLenum pname, GLint* @params);
    [DllImport(DllName)]
    public static extern unsafe GLvoid LightModel(GLenum pname, GLfloat param);
    [DllImport(DllName)]
    public static extern unsafe GLvoid LightModel(GLenum pname, GLfloat* @params);
    [DllImport(DllName)]
    public static extern unsafe GLvoid LightModel(GLenum pname, GLint param);
    [DllImport(DllName)]
    public static extern unsafe GLvoid LightModel(GLenum pname, GLint* @params);
    [DllImport(DllName)]
    public static extern unsafe GLvoid ColorMaterial(GLenum face, GLenum mode);
    [DllImport(DllName)]
    public static extern unsafe GLvoid ProvokingVertex(GLenum mode);
    [DllImport(DllName)]
    public static extern unsafe GLvoid ShadeModel(GLenum mode);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GetLight(GLenum light, GLenum pname, GLfloat* @params);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GetLight(GLenum light, GLenum pname, GLint* @params);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GetMaterial(GLenum face, GLenum pname, GLfloat* @params);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GetMaterial(GLenum face, GLenum pname, GLint* @params);
}