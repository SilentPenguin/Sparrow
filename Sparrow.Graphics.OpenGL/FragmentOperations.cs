using System.Runtime.InteropServices;

public static partial class Gl
{
    [DllImport(DllName)]
    public static extern unsafe GLvoid Scissor(GLint x, GLint y, GLsizei width, GLsizei height);
    [DllImport(DllName)]
    public static extern unsafe GLvoid SampleCoverage(GLfloat value, GLboolean invert);
    [DllImport(DllName)]
    public static extern unsafe GLvoid SampleMask(GLuint maskNumber, GLbitfield mask);
    [DllImport(DllName)]
    public static extern unsafe GLvoid AlphaFunc(GLenum func, GLfloat @ref);
    [DllImport(DllName)]
    public static extern unsafe GLvoid StencilFunc(GLenum func, GLint @ref, GLuint mask);
    [DllImport(DllName)]
    public static extern unsafe GLvoid StencilFuncSeparate(GLenum face, GLenum func, GLint @ref, GLuint mask);
    [DllImport(DllName)]
    public static extern unsafe GLvoid StencilOp(GLenum fail, GLenum zfail, GLenum zpass);
    [DllImport(DllName)]
    public static extern unsafe GLvoid StencilOpSeparate(GLenum face, GLenum sfail, GLenum dpfail, GLenum dppass);
    [DllImport(DllName)]
    public static extern unsafe GLvoid DepthFunc(GLenum func);
    [DllImport(DllName)]
    public static extern unsafe GLvoid BeginQuery(GLenum target, GLuint id);
    [DllImport(DllName)]
    public static extern unsafe GLvoid EndQuery(GLenum target);
    [DllImport(DllName)]
    public static extern unsafe GLvoid BlendEquation(GLenum mode);
    [DllImport(DllName)]
    public static extern unsafe GLvoid BlendEquationSeparate(GLenum modeRGB, GLenum modeAlpha);
    [DllImport(DllName)]
    public static extern unsafe GLvoid BlendFunc(GLenum sfactor, GLenum dfactor);
    [DllImport(DllName)]
    public static extern unsafe GLvoid BlendFuncSeparate(GLenum sfactorRGB, GLenum dfactorRGB, GLenum sfactorAlpha, GLenum dfactorAlpha);
    [DllImport(DllName)]
    public static extern unsafe GLvoid BlendColor(GLfloat red, GLfloat green, GLfloat blue, GLfloat alpha);
    [DllImport(DllName)]
    public static extern unsafe GLvoid LogicOp(GLenum opcode);
    [DllImport(DllName)]
    public static extern unsafe GLvoid DrawBuffer(GLenum buf);
    [DllImport(DllName)]
    public static extern unsafe GLvoid DrawBuffers(GLsizei n, GLenum* bufs);
    [DllImport(DllName)]
    public static extern unsafe GLvoid IndexMask(GLuint mask);
    [DllImport(DllName)]
    public static extern unsafe GLvoid ColorMask(GLboolean red, GLboolean green, GLboolean blue, GLboolean alpha);
    [DllImport(DllName)]
    public static extern unsafe GLvoid ColorMask(GLuint index, GLboolean r, GLboolean g, GLboolean b, GLboolean a);
    [DllImport(DllName)]
    public static extern unsafe GLvoid DepthMask(GLboolean flag);
    [DllImport(DllName)]
    public static extern unsafe GLvoid StencilMask(GLuint mask);
    [DllImport(DllName)]
    public static extern unsafe GLvoid StencilMaskSeparate(GLenum face, GLuint mask);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Clear(GLbitfield mask);
    [DllImport(DllName)]
    public static extern unsafe GLvoid ClearColor(GLfloat red, GLfloat green, GLfloat blue, GLfloat alpha);
    [DllImport(DllName)]
    public static extern unsafe GLvoid ClearDepth(GLdouble depth);
    [DllImport(DllName)]
    public static extern unsafe GLvoid ClearStencil(GLint s);
    [DllImport(DllName)]
    public static extern unsafe GLvoid ClearAccum(GLfloat red, GLfloat green, GLfloat blue, GLfloat alpha);
    [DllImport(DllName)]
    public static extern unsafe GLvoid ClearBuffer(GLenum buffer, GLint drawbuffer, GLfloat* value);
    [DllImport(DllName)]
    public static extern unsafe GLvoid ClearBuffer(GLenum buffer, GLint drawbuffer, GLint* value);
    [DllImport(DllName)]
    public static extern unsafe GLvoid ClearBuffer(GLenum buffer, GLint drawbuffer, GLuint* value);
    [DllImport(DllName)]
    public static extern unsafe GLvoid ClearBuffer(GLenum buffer, GLint drawbuffer, GLfloat depth, GLint stencil);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Accum(GLenum op, GLfloat value);
}