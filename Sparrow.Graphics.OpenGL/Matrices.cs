using System.Runtime.InteropServices;

public static partial class Gl
{
    [DllImport(DllName)]
    public static extern unsafe GLvoid Rect(GLdouble x1, GLdouble y1, GLdouble x2, GLdouble y2);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Rect(GLdouble* v1, GLdouble* v2);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Rect(GLfloat x1, GLfloat y1, GLfloat x2, GLfloat y2);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Rect(GLfloat* v1, GLfloat* v2);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Rect(GLint x1, GLint y1, GLint x2, GLint y2);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Rect(GLint* v1, GLint* v2);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Rect(GLshort x1, GLshort y1, GLshort x2, GLshort y2);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Rect(GLshort* v1, GLshort* v2);
    [DllImport(DllName)]
    public static extern unsafe GLvoid MatrixMode(GLenum mode);
    [DllImport(DllName)]
    public static extern unsafe GLvoid LoadMatrix(GLdouble* m);
    [DllImport(DllName)]
    public static extern unsafe GLvoid LoadMatrix(GLfloat* m);
    [DllImport(DllName)]
    public static extern unsafe GLvoid LoadTransposeMatrix(GLdouble* m);
    [DllImport(DllName)]
    public static extern unsafe GLvoid LoadTransposeMatrix(GLfloat* m);
    [DllImport(DllName)]
    public static extern unsafe GLvoid LoadIdentity();
    [DllImport(DllName)]
    public static extern unsafe GLvoid Rotate(GLdouble angle, GLdouble x, GLdouble y, GLdouble z);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Rotate(GLfloat angle, GLfloat x, GLfloat y, GLfloat z);
    [DllImport(DllName)]
    public static extern unsafe GLvoid LoadMatrix(GLdouble* m);
    [DllImport(DllName)]
    public static extern unsafe GLvoid LoadMatrix(GLfloat* m);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Translate(GLdouble x, GLdouble y, GLdouble z);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Translate(GLfloat x, GLfloat y, GLfloat z);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Scale(GLdouble x, GLdouble y, GLdouble z);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Scale(GLfloat x, GLfloat y, GLfloat z);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Ortho(GLdouble left, GLdouble right, GLdouble bottom, GLdouble top, GLdouble zNear, GLdouble zFar);
    [DllImport(DllName)]
    public static extern unsafe GLvoid PushMatrix();
    [DllImport(DllName)]
    public static extern unsafe GLvoid PopMatrix();
    [DllImport(DllName)]
    public static extern unsafe GLvoid TexGen(GLenum coord, GLenum pname, GLdouble param);
    [DllImport(DllName)]
    public static extern unsafe GLvoid TexGen(GLenum coord, GLenum pname, GLdouble* @params);
    [DllImport(DllName)]
    public static extern unsafe GLvoid TexGen(GLenum coord, GLenum pname, GLfloat param);
    [DllImport(DllName)]
    public static extern unsafe GLvoid TexGen(GLenum coord, GLenum pname, GLfloat* @params);
    [DllImport(DllName)]
    public static extern unsafe GLvoid TexGen(GLenum coord, GLenum pname, GLint param);
    [DllImport(DllName)]
    public static extern unsafe GLvoid TexGen(GLenum coord, GLenum pname, GLint* @params);
}