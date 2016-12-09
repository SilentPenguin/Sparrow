using System.Runtime.InteropServices;

public static partial class Gl
{
    [DllImport(DllName, EntryPoint = "glBeginConditionalRender")]
    public static extern unsafe GLvoid BeginConditionalRender(GLuint id, GLenum mode);
    [DllImport(DllName, EntryPoint = "glEndConditionalRender")]
    public static extern unsafe GLvoid EndConditionalRender();
    [DllImport(DllName, EntryPoint = "glBeginTransformFeedback")]
    public static extern unsafe GLvoid BeginTransformFeedback(GLenum primitiveMode);
    [DllImport(DllName, EntryPoint = "glEndTransformFeedback")]
    public static extern unsafe GLvoid EndTransformFeedback();
    [DllImport(DllName, EntryPoint = "glRasterPos2d")]
    public static extern unsafe GLvoid RasterPos2(GLdouble x, GLdouble y);
    [DllImport(DllName, EntryPoint = "glRasterPos2dv")]
    public static extern unsafe GLvoid RasterPos2(GLdouble* v);
    [DllImport(DllName, EntryPoint = "glRasterPos2f")]
    public static extern unsafe GLvoid RasterPos2(GLfloat x, GLfloat y);
    [DllImport(DllName, EntryPoint = "glRasterPos2fv")]
    public static extern unsafe GLvoid RasterPos2(GLfloat* v);
    [DllImport(DllName, EntryPoint = "glRasterPos2i")]
    public static extern unsafe GLvoid RasterPos2(GLint x, GLint y);
    [DllImport(DllName, EntryPoint = "glRasterPos2iv")]
    public static extern unsafe GLvoid RasterPos2(GLint* v);
    [DllImport(DllName, EntryPoint = "glRasterPos2s")]
    public static extern unsafe GLvoid RasterPos2(GLshort x, GLshort y);
    [DllImport(DllName, EntryPoint = "glRasterPos2sv")]
    public static extern unsafe GLvoid RasterPos2(GLshort* v);
    [DllImport(DllName, EntryPoint = "glRasterPos3d")]
    public static extern unsafe GLvoid RasterPos3(GLdouble x, GLdouble y, GLdouble z);
    [DllImport(DllName, EntryPoint = "glRasterPos3dv")]
    public static extern unsafe GLvoid RasterPos3(GLdouble* v);
    [DllImport(DllName, EntryPoint = "glRasterPos3f")]
    public static extern unsafe GLvoid RasterPos3(GLfloat x, GLfloat y, GLfloat z);
    [DllImport(DllName, EntryPoint = "glRasterPos3fv")]
    public static extern unsafe GLvoid RasterPos3(GLfloat* v);
    [DllImport(DllName, EntryPoint = "glRasterPos3i")]
    public static extern unsafe GLvoid RasterPos3(GLint x, GLint y, GLint z);
    [DllImport(DllName, EntryPoint = "glRasterPos3iv")]
    public static extern unsafe GLvoid RasterPos3(GLint* v);
    [DllImport(DllName, EntryPoint = "glRasterPos3s")]
    public static extern unsafe GLvoid RasterPos3(GLshort x, GLshort y, GLshort z);
    [DllImport(DllName, EntryPoint = "glRasterPos3sv")]
    public static extern unsafe GLvoid RasterPos3(GLshort* v);
    [DllImport(DllName, EntryPoint = "glRasterPos4d")]
    public static extern unsafe GLvoid RasterPos4(GLdouble x, GLdouble y, GLdouble z, GLdouble w);
    [DllImport(DllName, EntryPoint = "glRasterPos4dv")]
    public static extern unsafe GLvoid RasterPos4(GLdouble* v);
    [DllImport(DllName, EntryPoint = "glRasterPos4f")]
    public static extern unsafe GLvoid RasterPos4(GLfloat x, GLfloat y, GLfloat z, GLfloat w);
    [DllImport(DllName, EntryPoint = "glRasterPos4fv")]
    public static extern unsafe GLvoid RasterPos4(GLfloat* v);
    [DllImport(DllName, EntryPoint = "glRasterPos4i")]
    public static extern unsafe GLvoid RasterPos4(GLint x, GLint y, GLint z, GLint w);
    [DllImport(DllName, EntryPoint = "glRasterPos4iv")]
    public static extern unsafe GLvoid RasterPos4(GLint* v);
    [DllImport(DllName, EntryPoint = "glRasterPos4s")]
    public static extern unsafe GLvoid RasterPos4(GLshort x, GLshort y, GLshort z, GLshort w);
    [DllImport(DllName, EntryPoint = "glRasterPos4sv")]
    public static extern unsafe GLvoid RasterPos4(GLshort* v);
    [DllImport(DllName, EntryPoint = "glWindowPos2d")]
    public static extern unsafe GLvoid WindowPos2(GLdouble x, GLdouble y);
    [DllImport(DllName, EntryPoint = "glWindowPos2dv")]
    public static extern unsafe GLvoid WindowPos2(GLdouble* v);
    [DllImport(DllName, EntryPoint = "glWindowPos2f")]
    public static extern unsafe GLvoid WindowPos2(GLfloat x, GLfloat y);
    [DllImport(DllName, EntryPoint = "glWindowPos2fv")]
    public static extern unsafe GLvoid WindowPos2(GLfloat* v);
    [DllImport(DllName, EntryPoint = "glWindowPos2i")]
    public static extern unsafe GLvoid WindowPos2(GLint x, GLint y);
    [DllImport(DllName, EntryPoint = "glWindowPos2iv")]
    public static extern unsafe GLvoid WindowPos2(GLint* v);
    [DllImport(DllName, EntryPoint = "glWindowPos2s")]
    public static extern unsafe GLvoid WindowPos2(GLshort x, GLshort y);
    [DllImport(DllName, EntryPoint = "glWindowPos2sv")]
    public static extern unsafe GLvoid WindowPos2(GLshort* v);
    [DllImport(DllName, EntryPoint = "glWindowPos3d")]
    public static extern unsafe GLvoid WindowPos3(GLdouble x, GLdouble y, GLdouble z);
    [DllImport(DllName, EntryPoint = "glWindowPos3dv")]
    public static extern unsafe GLvoid WindowPos3(GLdouble* v);
    [DllImport(DllName, EntryPoint = "glWindowPos3f")]
    public static extern unsafe GLvoid WindowPos3(GLfloat x, GLfloat y, GLfloat z);
    [DllImport(DllName, EntryPoint = "glWindowPos3fv")]
    public static extern unsafe GLvoid WindowPos3(GLfloat* v);
    [DllImport(DllName, EntryPoint = "glWindowPos3i")]
    public static extern unsafe GLvoid WindowPos3(GLint x, GLint y, GLint z);
    [DllImport(DllName, EntryPoint = "glWindowPos3iv")]
    public static extern unsafe GLvoid WindowPos3(GLint* v);
    [DllImport(DllName, EntryPoint = "glWindowPos3s")]
    public static extern unsafe GLvoid WindowPos3(GLshort x, GLshort y, GLshort z);
    [DllImport(DllName, EntryPoint = "glWindowPos3sv")]
    public static extern unsafe GLvoid WindowPos3(GLshort* v);
    [DllImport(DllName, EntryPoint = "glBeginQuery")]
    public static extern unsafe GLvoid BeginQuery(GLenum target, GLuint id);
    [DllImport(DllName, EntryPoint = "glEndQuery")]
    public static extern unsafe GLvoid EndQuery(GLenum target);
    [DllImport(DllName, EntryPoint = "glGenQueries")]
    public static extern unsafe GLvoid GenQueries(GLsizei n, GLuint* ids);
    [DllImport(DllName, EntryPoint = "glDeleteQueries")]
    public static extern unsafe GLvoid DeleteQueries(GLsizei n, GLuint* ids);
    [DllImport(DllName, EntryPoint = "glIsQuery")]
    public static extern unsafe GLvoid IsQuery(GLuint id);
    [DllImport(DllName, EntryPoint = "glGetQueryiv")]
    public static extern unsafe GLvoid GetQuery(GLenum target, GLenum pname, GLint* @params);
    [DllImport(DllName, EntryPoint = "glGetQueryObjectiv")]
    public static extern unsafe GLvoid GetQueryObject(GLuint id, GLenum pname, GLint* @params);
    [DllImport(DllName, EntryPoint = "glGetQueryObjectuiv")]
    public static extern unsafe GLvoid GetQueryObject(GLuint id, GLenum pname, GLuint* @params);
}