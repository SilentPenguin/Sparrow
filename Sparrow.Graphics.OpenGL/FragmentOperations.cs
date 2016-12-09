using System.Runtime.InteropServices;

public static partial class Gl
{
    [DllImport(DllName, EntryPoint = "glScissor")]
    public static extern unsafe GLvoid Scissor(GLint x, GLint y, GLsizei width, GLsizei height);
    [DllImport(DllName, EntryPoint = "glSampleCoverage")]
    public static extern unsafe GLvoid SampleCoverage(GLfloat value, GLboolean invert);
    [DllImport(DllName, EntryPoint = "glSampleMaski")]
    public static extern unsafe GLvoid SampleMask(GLuint maskNumber, GLbitfield mask);
    [DllImport(DllName, EntryPoint = "glAlphaFunc")]
    public static extern unsafe GLvoid AlphaFunc(GLenum func, GLfloat @ref);
    [DllImport(DllName, EntryPoint = "glStencilFunc")]
    public static extern unsafe GLvoid StencilFunc(GLenum func, GLint @ref, GLuint mask);
    [DllImport(DllName, EntryPoint = "glStencilFuncSeparate")]
    public static extern unsafe GLvoid StencilFuncSeparate(GLenum face, GLenum func, GLint @ref, GLuint mask);
    [DllImport(DllName, EntryPoint = "glStencilOp")]
    public static extern unsafe GLvoid StencilOp(GLenum fail, GLenum zfail, GLenum zpass);
    [DllImport(DllName, EntryPoint = "glStencilOpSeparate")]
    public static extern unsafe GLvoid StencilOpSeparate(GLenum face, GLenum sfail, GLenum dpfail, GLenum dppass);
    [DllImport(DllName, EntryPoint = "glDepthFunc")]
    public static extern unsafe GLvoid DepthFunc(GLenum func);
    [DllImport(DllName, EntryPoint = "glBeginQuery")]
    public static extern unsafe GLvoid BeginQuery(GLenum target, GLuint id);
    [DllImport(DllName, EntryPoint = "glEndQuery")]
    public static extern unsafe GLvoid EndQuery(GLenum target);
    [DllImport(DllName, EntryPoint = "glBlendEquation")]
    public static extern unsafe GLvoid BlendEquation(GLenum mode);
    [DllImport(DllName, EntryPoint = "glBlendEquationSeparate")]
    public static extern unsafe GLvoid BlendEquationSeparate(GLenum modeRGB, GLenum modeAlpha);
    [DllImport(DllName, EntryPoint = "glBlendFunc")]
    public static extern unsafe GLvoid BlendFunc(GLenum sfactor, GLenum dfactor);
    [DllImport(DllName, EntryPoint = "glBlendFuncSeparate")]
    public static extern unsafe GLvoid BlendFuncSeparate(GLenum sfactorRGB, GLenum dfactorRGB, GLenum sfactorAlpha, GLenum dfactorAlpha);
    [DllImport(DllName, EntryPoint = "glBlendColor")]
    public static extern unsafe GLvoid BlendColor(GLfloat red, GLfloat green, GLfloat blue, GLfloat alpha);
    [DllImport(DllName, EntryPoint = "glLogicOp")]
    public static extern unsafe GLvoid LogicOp(GLenum opcode);
    [DllImport(DllName, EntryPoint = "glDrawBuffer")]
    public static extern unsafe GLvoid DrawBuffer(GLenum buf);
    [DllImport(DllName, EntryPoint = "glDrawBuffers")]
    public static extern unsafe GLvoid DrawBuffers(GLsizei n, GLenum* bufs);
    [DllImport(DllName, EntryPoint = "glIndexMask")]
    public static extern unsafe GLvoid IndexMask(GLuint mask);
    [DllImport(DllName, EntryPoint = "glColorMask")]
    public static extern unsafe GLvoid ColorMask(GLboolean red, GLboolean green, GLboolean blue, GLboolean alpha);
    [DllImport(DllName, EntryPoint = "glColorMaski")]
    public static extern unsafe GLvoid ColorMask(GLuint index, GLboolean r, GLboolean g, GLboolean b, GLboolean a);
    [DllImport(DllName, EntryPoint = "glDepthMask")]
    public static extern unsafe GLvoid DepthMask(GLboolean flag);
    [DllImport(DllName, EntryPoint = "glStencilMask")]
    public static extern unsafe GLvoid StencilMask(GLuint mask);
    [DllImport(DllName, EntryPoint = "glStencilMaskSeparate")]
    public static extern unsafe GLvoid StencilMaskSeparate(GLenum face, GLuint mask);
    [DllImport(DllName, EntryPoint = "glClear")]
    public static extern unsafe GLvoid Clear(GLbitfield mask);
    [DllImport(DllName, EntryPoint = "glClearColor")]
    public static extern unsafe GLvoid ClearColor(GLfloat red, GLfloat green, GLfloat blue, GLfloat alpha);
    [DllImport(DllName, EntryPoint = "glClearDepth")]
    public static extern unsafe GLvoid ClearDepth(GLdouble depth);
    [DllImport(DllName, EntryPoint = "glClearStencil")]
    public static extern unsafe GLvoid ClearStencil(GLint s);
    [DllImport(DllName, EntryPoint = "glClearAccum")]
    public static extern unsafe GLvoid ClearAccum(GLfloat red, GLfloat green, GLfloat blue, GLfloat alpha);
    [DllImport(DllName, EntryPoint = "glClearBufferfv")]
    public static extern unsafe GLvoid ClearBuffer(GLenum buffer, GLint drawbuffer, GLfloat* value);
    [DllImport(DllName, EntryPoint = "glClearBufferiv")]
    public static extern unsafe GLvoid ClearBuffer(GLenum buffer, GLint drawbuffer, GLint* value);
    [DllImport(DllName, EntryPoint = "glClearBufferuiv")]
    public static extern unsafe GLvoid ClearBuffer(GLenum buffer, GLint drawbuffer, GLuint* value);
    [DllImport(DllName, EntryPoint = "glClearBufferfi")]
    public static extern unsafe GLvoid ClearBuffer(GLenum buffer, GLint drawbuffer, GLfloat depth, GLint stencil);
    [DllImport(DllName, EntryPoint = "glAccum")]
    public static extern unsafe GLvoid Accum(GLenum op, GLfloat value);
}