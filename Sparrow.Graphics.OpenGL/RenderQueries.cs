using System.Runtime.InteropServices;

public static partial class Gl
{
    [DllImport(DllName)]
    public static extern unsafe GLvoid BeginConditionalRender(GLuint id, GLenum mode);
    [DllImport(DllName)]
    public static extern unsafe GLvoid EndConditionalRender();
    [DllImport(DllName)]
    public static extern unsafe GLvoid BeginTransformFeedback(GLenum primitiveMode);
    [DllImport(DllName)]
    public static extern unsafe GLvoid EndTransformFeedback();
    [DllImport(DllName)]
    public static extern unsafe GLvoid RasterPos2(GLdouble x, GLdouble y);
    [DllImport(DllName)]
    public static extern unsafe GLvoid RasterPos2(GLdouble* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid RasterPos2(GLfloat x, GLfloat y);
    [DllImport(DllName)]
    public static extern unsafe GLvoid RasterPos2(GLfloat* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid RasterPos2(GLint x, GLint y);
    [DllImport(DllName)]
    public static extern unsafe GLvoid RasterPos2(GLint* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid RasterPos2(GLshort x, GLshort y);
    [DllImport(DllName)]
    public static extern unsafe GLvoid RasterPos2(GLshort* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid RasterPos3(GLdouble x, GLdouble y, GLdouble z);
    [DllImport(DllName)]
    public static extern unsafe GLvoid RasterPos3(GLdouble* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid RasterPos3(GLfloat x, GLfloat y, GLfloat z);
    [DllImport(DllName)]
    public static extern unsafe GLvoid RasterPos3(GLfloat* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid RasterPos3(GLint x, GLint y, GLint z);
    [DllImport(DllName)]
    public static extern unsafe GLvoid RasterPos3(GLint* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid RasterPos3(GLshort x, GLshort y, GLshort z);
    [DllImport(DllName)]
    public static extern unsafe GLvoid RasterPos3(GLshort* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid RasterPos4(GLdouble x, GLdouble y, GLdouble z, GLdouble w);
    [DllImport(DllName)]
    public static extern unsafe GLvoid RasterPos4(GLdouble* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid RasterPos4(GLfloat x, GLfloat y, GLfloat z, GLfloat w);
    [DllImport(DllName)]
    public static extern unsafe GLvoid RasterPos4(GLfloat* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid RasterPos4(GLint x, GLint y, GLint z, GLint w);
    [DllImport(DllName)]
    public static extern unsafe GLvoid RasterPos4(GLint* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid RasterPos4(GLshort x, GLshort y, GLshort z, GLshort w);
    [DllImport(DllName)]
    public static extern unsafe GLvoid RasterPos4(GLshort* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid WindowPos2(GLdouble x, GLdouble y);
    [DllImport(DllName)]
    public static extern unsafe GLvoid WindowPos2(GLdouble* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid WindowPos2(GLfloat x, GLfloat y);
    [DllImport(DllName)]
    public static extern unsafe GLvoid WindowPos2(GLfloat* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid WindowPos2(GLint x, GLint y);
    [DllImport(DllName)]
    public static extern unsafe GLvoid WindowPos2(GLint* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid WindowPos2(GLshort x, GLshort y);
    [DllImport(DllName)]
    public static extern unsafe GLvoid WindowPos2(GLshort* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid WindowPos3(GLdouble x, GLdouble y, GLdouble z);
    [DllImport(DllName)]
    public static extern unsafe GLvoid WindowPos3(GLdouble* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid WindowPos3(GLfloat x, GLfloat y, GLfloat z);
    [DllImport(DllName)]
    public static extern unsafe GLvoid WindowPos3(GLfloat* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid WindowPos3(GLint x, GLint y, GLint z);
    [DllImport(DllName)]
    public static extern unsafe GLvoid WindowPos3(GLint* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid WindowPos3(GLshort x, GLshort y, GLshort z);
    [DllImport(DllName)]
    public static extern unsafe GLvoid WindowPos3(GLshort* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid BeginQuery(GLenum target, GLuint id);
    [DllImport(DllName)]
    public static extern unsafe GLvoid EndQuery(GLenum target);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GenQueries(GLsizei n, GLuint* ids);
    [DllImport(DllName)]
    public static extern unsafe GLvoid DeleteQueries(GLsizei n, GLuint* ids);
    [DllImport(DllName)]
    public static extern unsafe GLvoid IsQuery(GLuint id);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GetQuery(GLenum target, GLenum pname, GLint* @params);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GetQueryObject(GLuint id, GLenum pname, GLint* @params);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GetQueryObject(GLuint id, GLenum pname, GLuint* @params);
}