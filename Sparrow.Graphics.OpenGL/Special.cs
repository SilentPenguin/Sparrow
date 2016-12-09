using System.Runtime.InteropServices;

public static partial class Gl
{
    [DllImport(DllName, EntryPoint = "glMap1d")]
    public static extern unsafe GLvoid Map1(GLenum target, GLdouble u1, GLdouble u2, GLint stride, GLint order, GLdouble* points);
    [DllImport(DllName, EntryPoint = "glMap1f")]
    public static extern unsafe GLvoid Map1(GLenum target, GLfloat u1, GLfloat u2, GLint stride, GLint order, GLfloat* points);
    [DllImport(DllName, EntryPoint = "glMap2d")]
    public static extern unsafe GLvoid Map2(GLenum target, GLdouble u1, GLdouble u2, GLint ustride, GLint uorder, GLdouble v1, GLdouble v2, GLint vstride, GLint vorder, GLdouble* points);
    [DllImport(DllName, EntryPoint = "glMap2f")]
    public static extern unsafe GLvoid Map2(GLenum target, GLfloat u1, GLfloat u2, GLint ustride, GLint uorder, GLfloat v1, GLfloat v2, GLint vstride, GLint vorder, GLfloat* points);
    [DllImport(DllName, EntryPoint = "glEvalCoord1d")]
    public static extern unsafe GLvoid EvalCoord1(GLdouble u);
    [DllImport(DllName, EntryPoint = "glEvalCoord1dv")]
    public static extern unsafe GLvoid EvalCoord1(GLdouble* u);
    [DllImport(DllName, EntryPoint = "glEvalCoord1f")]
    public static extern unsafe GLvoid EvalCoord1(GLfloat u);
    [DllImport(DllName, EntryPoint = "glEvalCoord1fv")]
    public static extern unsafe GLvoid EvalCoord1(GLfloat* u);
    [DllImport(DllName, EntryPoint = "glEvalCoord2d")]
    public static extern unsafe GLvoid EvalCoord2(GLdouble u, GLdouble v);
    [DllImport(DllName, EntryPoint = "glEvalCoord2dv")]
    public static extern unsafe GLvoid EvalCoord2(GLdouble* u);
    [DllImport(DllName, EntryPoint = "glEvalCoord2f")]
    public static extern unsafe GLvoid EvalCoord2(GLfloat u, GLfloat v);
    [DllImport(DllName, EntryPoint = "glEvalCoord2fv")]
    public static extern unsafe GLvoid EvalCoord2(GLfloat* u);
    [DllImport(DllName, EntryPoint = "glMapGrid1d")]
    public static extern unsafe GLvoid MapGrid1(GLint un, GLdouble u1, GLdouble u2);
    [DllImport(DllName, EntryPoint = "glMapGrid1f")]
    public static extern unsafe GLvoid MapGrid1(GLint un, GLfloat u1, GLfloat u2);
    [DllImport(DllName, EntryPoint = "glMapGrid2d")]
    public static extern unsafe GLvoid MapGrid2(GLint un, GLdouble u1, GLdouble u2, GLint vn, GLdouble v1, GLdouble v2);
    [DllImport(DllName, EntryPoint = "glMapGrid2f")]
    public static extern unsafe GLvoid MapGrid2(GLint un, GLfloat u1, GLfloat u2, GLint vn, GLfloat v1, GLfloat v2);
    [DllImport(DllName, EntryPoint = "glEvalMesh1")]
    public static extern unsafe GLvoid EvalMesh1(GLenum mode, GLint i1, GLint i2);
    [DllImport(DllName, EntryPoint = "glEvalMesh2")]
    public static extern unsafe GLvoid EvalMesh2(GLenum mode, GLint i1, GLint i2, GLint j1, GLint j2);
    [DllImport(DllName, EntryPoint = "glEvalPoint1")]
    public static extern unsafe GLvoid EvalPoint1(GLint i);
    [DllImport(DllName, EntryPoint = "glEvalPoint2")]
    public static extern unsafe GLvoid EvalPoint2(GLint i, GLint j);
    [DllImport(DllName, EntryPoint = "glGetMapdv")]
    public static extern unsafe GLvoid GetMap(GLenum target, GLenum query, GLdouble* v);
    [DllImport(DllName, EntryPoint = "glGetMapfv")]
    public static extern unsafe GLvoid GetMap(GLenum target, GLenum query, GLfloat* v);
    [DllImport(DllName, EntryPoint = "glGetMapiv")]
    public static extern unsafe GLvoid GetMap(GLenum target, GLenum query, GLint* v);
    [DllImport(DllName, EntryPoint = "glInitNames")]
    public static extern unsafe GLvoid InitNames();
    [DllImport(DllName, EntryPoint = "glPopName")]
    public static extern unsafe GLvoid PopName();
    [DllImport(DllName, EntryPoint = "glPushName")]
    public static extern unsafe GLvoid PushName(GLuint name);
    [DllImport(DllName, EntryPoint = "glLoadName")]
    public static extern unsafe GLvoid LoadName(GLuint name);
    [DllImport(DllName, EntryPoint = "glRenderMode")]
    public static extern unsafe GLvoid RenderMode(GLenum mode);
    [DllImport(DllName, EntryPoint = "glSelectBuffer")]
    public static extern unsafe GLvoid SelectBuffer(GLsizei size, GLuint* buffer);
    [DllImport(DllName, EntryPoint = "glFeedbackBuffer")]
    public static extern unsafe GLvoid FeedbackBuffer(GLsizei size, GLenum type, GLfloat* buffer);
    [DllImport(DllName, EntryPoint = "glPassThrough")]
    public static extern unsafe GLvoid PassThrough(GLfloat token);
    [DllImport(DllName, EntryPoint = "glNewList")]
    public static extern unsafe GLvoid NewList(GLuint list, GLenum mode);
    [DllImport(DllName, EntryPoint = "glEndList")]
    public static extern unsafe GLvoid EndList();
    [DllImport(DllName, EntryPoint = "glCallList")]
    public static extern unsafe GLvoid CallList(GLuint list);
    [DllImport(DllName, EntryPoint = "glCallLists")]
    public static extern unsafe GLvoid CallLists(GLsizei n, GLenum type, GLvoid* lists);
    [DllImport(DllName, EntryPoint = "glListBase")]
    public static extern unsafe GLvoid ListBase(GLuint @base);
    [DllImport(DllName, EntryPoint = "glGenLists")]
    public static extern unsafe GLvoid GenLists(GLsizei range);
    [DllImport(DllName, EntryPoint = "glIsList")]
    public static extern unsafe GLvoid IsList(GLuint list);
    [DllImport(DllName, EntryPoint = "glDeleteLists")]
    public static extern unsafe GLvoid DeleteLists(GLuint list, GLsizei range);
}