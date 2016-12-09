using System.Runtime.InteropServices;

public static partial class Gl
{
    [DllImport(DllName, EntryPoint = "glGetMultisamplefv")]
    public static extern unsafe GLvoid GetMultisample(GLenum pname, GLuint index, GLfloat* val);
    [DllImport(DllName, EntryPoint = "glPointSize")]
    public static extern unsafe GLvoid PointSize(GLfloat size);
    [DllImport(DllName, EntryPoint = "glPointParameterf")]
    public static extern unsafe GLvoid PointParameter(GLenum pname, GLfloat param);
    [DllImport(DllName, EntryPoint = "glPointParameterfv")]
    public static extern unsafe GLvoid PointParameter(GLenum pname, GLfloat* @params);
    [DllImport(DllName, EntryPoint = "glPointParameteri")]
    public static extern unsafe GLvoid PointParameter(GLenum pname, GLint param);
    [DllImport(DllName, EntryPoint = "glPointParameteriv")]
    public static extern unsafe GLvoid PointParameter(GLenum pname, GLint* @params);
    [DllImport(DllName, EntryPoint = "glLineWidth")]
    public static extern unsafe GLvoid LineWidth(GLfloat width);
    [DllImport(DllName, EntryPoint = "glLineStipple")]
    public static extern unsafe GLvoid LineStipple(GLint factor, GLushort pattern);
    [DllImport(DllName, EntryPoint = "glGetPolygonStipple")]
    public static extern unsafe GLvoid GetPolygonStipple(GLubyte* mask);
    [DllImport(DllName, EntryPoint = "glFrontFace")]
    public static extern unsafe GLvoid FrontFace(GLenum mode);
    [DllImport(DllName, EntryPoint = "glCullFace")]
    public static extern unsafe GLvoid CullFace(GLenum mode);
    [DllImport(DllName, EntryPoint = "glPolygonMode")]
    public static extern unsafe GLvoid PolygonMode(GLenum face, GLenum mode);
    [DllImport(DllName, EntryPoint = "glPolygonOffset")]
    public static extern unsafe GLvoid PolygonOffset(GLfloat factor, GLfloat units);
    [DllImport(DllName, EntryPoint = "glPixelStoref")]
    public static extern unsafe GLvoid PixelStore(GLenum pname, GLfloat param);
    [DllImport(DllName, EntryPoint = "glPixelStorei")]
    public static extern unsafe GLvoid PixelStore(GLenum pname, GLint param);
    [DllImport(DllName, EntryPoint = "glPixelMapfv")]
    public static extern unsafe GLvoid PixelMap(GLenum map, GLsizei mapsize, GLfloat* values);
    [DllImport(DllName, EntryPoint = "glPixelMapuiv")]
    public static extern unsafe GLvoid PixelMap(GLenum map, GLsizei mapsize, GLuint* values);
    [DllImport(DllName, EntryPoint = "glPixelMapusv")]
    public static extern unsafe GLvoid PixelMap(GLenum map, GLsizei mapsize, GLushort* values);
    [DllImport(DllName, EntryPoint = "glGetPixelMapfv")]
    public static extern unsafe GLvoid GetPixelMap(GLenum map, GLfloat* values);
    [DllImport(DllName, EntryPoint = "glGetPixelMapuiv")]
    public static extern unsafe GLvoid GetPixelMap(GLenum map, GLuint* values);
    [DllImport(DllName, EntryPoint = "glGetPixelMapusv")]
    public static extern unsafe GLvoid GetPixelMap(GLenum map, GLushort* values);
    [DllImport(DllName, EntryPoint = "glColorTable")]
    public static extern unsafe GLvoid ColorTable(GLenum target, GLenum internalformat, GLsizei width, GLenum format, GLenum type, GLvoid* table);
    [DllImport(DllName, EntryPoint = "glColorTableParameterfv")]
    public static extern unsafe GLvoid ColorTableParameter(GLenum target, GLenum pname, GLfloat* @params);
    [DllImport(DllName, EntryPoint = "glColorTableParameteriv")]
    public static extern unsafe GLvoid ColorTableParameter(GLenum target, GLenum pname, GLint* @params);
    [DllImport(DllName, EntryPoint = "glCopyColorTable")]
    public static extern unsafe GLvoid CopyColorTable(GLenum target, GLenum internalformat, GLint x, GLint y, GLsizei width);
    [DllImport(DllName, EntryPoint = "glColorSubTable")]
    public static extern unsafe GLvoid ColorSubTable(GLenum target, GLsizei start, GLsizei count, GLenum format, GLenum type, GLvoid* data);
    [DllImport(DllName, EntryPoint = "glCopyColorSubTable")]
    public static extern unsafe GLvoid CopyColorSubTable(GLenum target, GLsizei start, GLint x, GLint y, GLsizei width);
    [DllImport(DllName, EntryPoint = "glGetColorTable")]
    public static extern unsafe GLvoid GetColorTable(GLenum target, GLenum format, GLenum type, GLvoid* table);
    [DllImport(DllName, EntryPoint = "glGetColorTableParameterfv")]
    public static extern unsafe GLvoid GetColorTableParameter(GLenum target, GLenum pname, GLfloat* @params);
    [DllImport(DllName, EntryPoint = "glGetColorTableParameteriv")]
    public static extern unsafe GLvoid GetColorTableParameter(GLenum target, GLenum pname, GLint* @params);
    [DllImport(DllName, EntryPoint = "glConvolutionFilter1D")]
    public static extern unsafe GLvoid ConvolutionFilter1D(GLenum target, GLenum internalformat, GLsizei width, GLenum format, GLenum type, GLvoid* image);
    [DllImport(DllName, EntryPoint = "glConvolutionFilter2D")]
    public static extern unsafe GLvoid ConvolutionFilter2D(GLenum target, GLenum internalformat, GLsizei width, GLsizei height, GLenum format, GLenum type, GLvoid* image);
    [DllImport(DllName, EntryPoint = "glConvolutionParameterf")]
    public static extern unsafe GLvoid ConvolutionParameter(GLenum target, GLenum pname, GLfloat @params);
    [DllImport(DllName, EntryPoint = "glConvolutionParameterfv")]
    public static extern unsafe GLvoid ConvolutionParameter(GLenum target, GLenum pname, GLfloat* @params);
    [DllImport(DllName, EntryPoint = "glConvolutionParameteri")]
    public static extern unsafe GLvoid ConvolutionParameter(GLenum target, GLenum pname, GLint @params);
    [DllImport(DllName, EntryPoint = "glConvolutionParameteriv")]
    public static extern unsafe GLvoid ConvolutionParameter(GLenum target, GLenum pname, GLint* @params);
    [DllImport(DllName, EntryPoint = "glSeparableFilter2D")]
    public static extern unsafe GLvoid SeparableFilter2D(GLenum target, GLenum internalformat, GLsizei width, GLsizei height, GLenum format, GLenum type, GLvoid* row, GLvoid* column);
    [DllImport(DllName, EntryPoint = "glCopyConvolutionFilter1D")]
    public static extern unsafe GLvoid CopyConvolutionFilter1D(GLenum target, GLenum internalformat, GLint x, GLint y, GLsizei width);
    [DllImport(DllName, EntryPoint = "glCopyConvolutionFilter2D")]
    public static extern unsafe GLvoid CopyConvolutionFilter2D(GLenum target, GLenum internalformat, GLint x, GLint y, GLsizei width, GLsizei height);
    [DllImport(DllName, EntryPoint = "glGetConvolutionFilter")]
    public static extern unsafe GLvoid GetConvolutionFilter(GLenum target, GLenum format, GLenum type, GLvoid* image);
    [DllImport(DllName, EntryPoint = "glGetSeparableFilter")]
    public static extern unsafe GLvoid GetSeparableFilter(GLenum target, GLenum format, GLenum type, GLvoid* row, GLvoid* column, GLvoid* span);
    [DllImport(DllName, EntryPoint = "glGetConvolutionParameterfv")]
    public static extern unsafe GLvoid GetConvolutionParameter(GLenum target, GLenum pname, GLfloat* @params);
    [DllImport(DllName, EntryPoint = "glGetConvolutionParameteriv")]
    public static extern unsafe GLvoid GetConvolutionParameter(GLenum target, GLenum pname, GLint* @params);
    [DllImport(DllName, EntryPoint = "glHistogram")]
    public static extern unsafe GLvoid Histogram(GLenum target, GLsizei width, GLenum internalformat, GLboolean sink);
    [DllImport(DllName, EntryPoint = "glGetHistogram")]
    public static extern unsafe GLvoid GetHistogram(GLenum target, GLboolean reset, GLenum format, GLenum type, GLvoid* values);
    [DllImport(DllName, EntryPoint = "glResetHistogram")]
    public static extern unsafe GLvoid ResetHistogram(GLenum target);
    [DllImport(DllName, EntryPoint = "glGetHistogramParameterfv")]
    public static extern unsafe GLvoid GetHistogramParameter(GLenum target, GLenum pname, GLfloat* @params);
    [DllImport(DllName, EntryPoint = "glGetHistogramParameteriv")]
    public static extern unsafe GLvoid GetHistogramParameter(GLenum target, GLenum pname, GLint* @params);
    [DllImport(DllName, EntryPoint = "glMinmax")]
    public static extern unsafe GLvoid Minmax(GLenum target, GLenum internalformat, GLboolean sink);
    [DllImport(DllName, EntryPoint = "glGetMinmax")]
    public static extern unsafe GLvoid GetMinmax(GLenum target, GLboolean reset, GLenum format, GLenum type, GLvoid* values);
    [DllImport(DllName, EntryPoint = "glResetMinmax")]
    public static extern unsafe GLvoid ResetMinmax(GLenum target);
    [DllImport(DllName, EntryPoint = "glGetMinmaxParameterfv")]
    public static extern unsafe GLvoid GetMinmaxParameter(GLenum target, GLenum pname, GLfloat* @params);
    [DllImport(DllName, EntryPoint = "glGetMinmaxParameteriv")]
    public static extern unsafe GLvoid GetMinmaxParameter(GLenum target, GLenum pname, GLint* @params);
    [DllImport(DllName, EntryPoint = "glDrawPixels")]
    public static extern unsafe GLvoid DrawPixels(GLsizei width, GLsizei height, GLenum format, GLenum type, GLvoid* pixels);
    [DllImport(DllName, EntryPoint = "glClampColor")]
    public static extern unsafe GLvoid ClampColor(GLenum target, GLenum clamp);
    [DllImport(DllName, EntryPoint = "glPixelZoom")]
    public static extern unsafe GLvoid PixelZoom(GLfloat xfactor, GLfloat yfactor);
    [DllImport(DllName, EntryPoint = "glBitmap")]
    public static extern unsafe GLvoid Bitmap(GLsizei width, GLsizei height, GLfloat xorig, GLfloat yorig, GLfloat xmove, GLfloat ymove, GLubyte* bitmap);
}