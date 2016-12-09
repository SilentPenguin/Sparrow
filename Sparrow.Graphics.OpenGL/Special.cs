using System.Runtime.InteropServices;

public static partial class Gl
{
    [DllImport(DllName)]
    public static extern unsafe GLvoid Map1(GLenum target, GLdouble u1, GLdouble u2, GLint stride, GLint order, GLdouble* points);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Map1(GLenum target, GLfloat u1, GLfloat u2, GLint stride, GLint order, GLfloat* points);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Map2(GLenum target, GLdouble u1, GLdouble u2, GLint ustride, GLint uorder, GLdouble v1, GLdouble v2, GLint vstride, GLint vorder, GLdouble* points);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Map2(GLenum target, GLfloat u1, GLfloat u2, GLint ustride, GLint uorder, GLfloat v1, GLfloat v2, GLint vstride, GLint vorder, GLfloat* points);
    [DllImport(DllName)]
    public static extern unsafe GLvoid EvalCoord1(GLdouble u);
    [DllImport(DllName)]
    public static extern unsafe GLvoid EvalCoord1(GLdouble* u);
    [DllImport(DllName)]
    public static extern unsafe GLvoid EvalCoord1(GLfloat u);
    [DllImport(DllName)]
    public static extern unsafe GLvoid EvalCoord1(GLfloat* u);
    [DllImport(DllName)]
    public static extern unsafe GLvoid EvalCoord2(GLdouble u, GLdouble v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid EvalCoord2(GLdouble* u);
    [DllImport(DllName)]
    public static extern unsafe GLvoid EvalCoord2(GLfloat u, GLfloat v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid EvalCoord2(GLfloat* u);
    [DllImport(DllName)]
    public static extern unsafe GLvoid MapGrid1(GLint un, GLdouble u1, GLdouble u2);
    [DllImport(DllName)]
    public static extern unsafe GLvoid MapGrid1(GLint un, GLfloat u1, GLfloat u2);
    [DllImport(DllName)]
    public static extern unsafe GLvoid MapGrid2(GLint un, GLdouble u1, GLdouble u2, GLint vn, GLdouble v1, GLdouble v2);
    [DllImport(DllName)]
    public static extern unsafe GLvoid MapGrid2(GLint un, GLfloat u1, GLfloat u2, GLint vn, GLfloat v1, GLfloat v2);
    [DllImport(DllName)]
    public static extern unsafe GLvoid EvalMesh1(GLenum mode, GLint i1, GLint i2);
    [DllImport(DllName)]
    public static extern unsafe GLvoid EvalMesh2(GLenum mode, GLint i1, GLint i2, GLint j1, GLint j2);
    [DllImport(DllName)]
    public static extern unsafe GLvoid EvalPoint1(GLint i);
    [DllImport(DllName)]
    public static extern unsafe GLvoid EvalPoint2(GLint i, GLint j);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GetMap(GLenum target, GLenum query, GLdouble* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GetMap(GLenum target, GLenum query, GLfloat* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GetMap(GLenum target, GLenum query, GLint* v);
    [DllImport(DllName)]
    public static extern unsafe GLvoid InitNames();
    [DllImport(DllName)]
    public static extern unsafe GLvoid PopName();
    [DllImport(DllName)]
    public static extern unsafe GLvoid PushName(GLuint name);
    [DllImport(DllName)]
    public static extern unsafe GLvoid LoadName(GLuint name);
    [DllImport(DllName)]
    public static extern unsafe GLvoid RenderMode(GLenum mode);
    [DllImport(DllName)]
    public static extern unsafe GLvoid SelectBuffer(GLsizei size, GLuint* buffer);
    [DllImport(DllName)]
    public static extern unsafe GLvoid FeedbackBuffer(GLsizei size, GLenum type, GLfloat* buffer);
    [DllImport(DllName)]
    public static extern unsafe GLvoid PassThrough(GLfloat token);
    [DllImport(DllName)]
    public static extern unsafe GLvoid NewList(GLuint list, GLenum mode);
    [DllImport(DllName)]
    public static extern unsafe GLvoid EndList();
    [DllImport(DllName)]
    public static extern unsafe GLvoid CallList(GLuint list);
    [DllImport(DllName)]
    public static extern unsafe GLvoid CallLists(GLsizei n, GLenum type, GLvoid* lists);
    [DllImport(DllName)]
    public static extern unsafe GLvoid ListBase(GLuint @base);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GenLists(GLsizei range);
    [DllImport(DllName)]
    public static extern unsafe GLvoid IsList(GLuint list);
    [DllImport(DllName)]
    public static extern unsafe GLvoid DeleteLists(GLuint list, GLsizei range);
}