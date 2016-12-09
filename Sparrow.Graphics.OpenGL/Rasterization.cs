using System.Runtime.InteropServices;

public static partial class Gl
{
    [DllImport(DllName)]
    public static extern unsafe GLvoid GetMultisample(GLenum pname, GLuint index, GLfloat* val);
    [DllImport(DllName)]
    public static extern unsafe GLvoid PointSize(GLfloat size);
    [DllImport(DllName)]
    public static extern unsafe GLvoid PointParameter(GLenum pname, GLfloat param);
    [DllImport(DllName)]
    public static extern unsafe GLvoid PointParameter(GLenum pname, GLfloat* @params);
    [DllImport(DllName)]
    public static extern unsafe GLvoid PointParameter(GLenum pname, GLint param);
    [DllImport(DllName)]
    public static extern unsafe GLvoid PointParameter(GLenum pname, GLint* @params);
    [DllImport(DllName)]
    public static extern unsafe GLvoid LineWidth(GLfloat width);
    [DllImport(DllName)]
    public static extern unsafe GLvoid LineStipple(GLint factor, GLushort pattern);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GetPolygonStipple(GLubyte* mask);
    [DllImport(DllName)]
    public static extern unsafe GLvoid FrontFace(GLenum mode);
    [DllImport(DllName)]
    public static extern unsafe GLvoid CullFace(GLenum mode);
    [DllImport(DllName)]
    public static extern unsafe GLvoid PolygonMode(GLenum face, GLenum mode);
    [DllImport(DllName)]
    public static extern unsafe GLvoid PolygonOffset(GLfloat factor, GLfloat units);
    [DllImport(DllName)]
    public static extern unsafe GLvoid PixelStore(GLenum pname, GLfloat param);
    [DllImport(DllName)]
    public static extern unsafe GLvoid PixelStore(GLenum pname, GLint param);
    [DllImport(DllName)]
    public static extern unsafe GLvoid PixelMap(GLenum map, GLsizei mapsize, GLfloat* values);
    [DllImport(DllName)]
    public static extern unsafe GLvoid PixelMap(GLenum map, GLsizei mapsize, GLuint* values);
    [DllImport(DllName)]
    public static extern unsafe GLvoid PixelMap(GLenum map, GLsizei mapsize, GLushort* values);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GetPixelMap(GLenum map, GLfloat* values);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GetPixelMap(GLenum map, GLuint* values);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GetPixelMap(GLenum map, GLushort* values);
    [DllImport(DllName)]
    public static extern unsafe GLvoid ColorTable(GLenum target, GLenum internalformat, GLsizei width, GLenum format, GLenum type, GLvoid* table);
    [DllImport(DllName)]
    public static extern unsafe GLvoid ColorTableParameter(GLenum target, GLenum pname, GLfloat* @params);
    [DllImport(DllName)]
    public static extern unsafe GLvoid ColorTableParameter(GLenum target, GLenum pname, GLint* @params);
    [DllImport(DllName)]
    public static extern unsafe GLvoid CopyColorTable(GLenum target, GLenum internalformat, GLint x, GLint y, GLsizei width);
    [DllImport(DllName)]
    public static extern unsafe GLvoid ColorSubTable(GLenum target, GLsizei start, GLsizei count, GLenum format, GLenum type, GLvoid* data);
    [DllImport(DllName)]
    public static extern unsafe GLvoid CopyColorSubTable(GLenum target, GLsizei start, GLint x, GLint y, GLsizei width);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GetColorTable(GLenum target, GLenum format, GLenum type, GLvoid* table);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GetColorTableParameter(GLenum target, GLenum pname, GLfloat* @params);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GetColorTableParameter(GLenum target, GLenum pname, GLint* @params);
    [DllImport(DllName)]
    public static extern unsafe GLvoid ConvolutionFilter1D(GLenum target, GLenum internalformat, GLsizei width, GLenum format, GLenum type, GLvoid* image);
    [DllImport(DllName)]
    public static extern unsafe GLvoid ConvolutionFilter2D(GLenum target, GLenum internalformat, GLsizei width, GLsizei height, GLenum format, GLenum type, GLvoid* image);
    [DllImport(DllName)]
    public static extern unsafe GLvoid ConvolutionParameter(GLenum target, GLenum pname, GLfloat @params);
    [DllImport(DllName)]
    public static extern unsafe GLvoid ConvolutionParameter(GLenum target, GLenum pname, GLfloat* @params);
    [DllImport(DllName)]
    public static extern unsafe GLvoid ConvolutionParameter(GLenum target, GLenum pname, GLint @params);
    [DllImport(DllName)]
    public static extern unsafe GLvoid ConvolutionParameter(GLenum target, GLenum pname, GLint* @params);
    [DllImport(DllName)]
    public static extern unsafe GLvoid SeparableFilter2D(GLenum target, GLenum internalformat, GLsizei width, GLsizei height, GLenum format, GLenum type, GLvoid* row, GLvoid* column);
    [DllImport(DllName)]
    public static extern unsafe GLvoid CopyConvolutionFilter1D(GLenum target, GLenum internalformat, GLint x, GLint y, GLsizei width);
    [DllImport(DllName)]
    public static extern unsafe GLvoid CopyConvolutionFilter2D(GLenum target, GLenum internalformat, GLint x, GLint y, GLsizei width, GLsizei height);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GetConvolutionFilter(GLenum target, GLenum format, GLenum type, GLvoid* image);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GetSeparableFilter(GLenum target, GLenum format, GLenum type, GLvoid* row, GLvoid* column, GLvoid* span);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GetConvolutionParameter(GLenum target, GLenum pname, GLfloat* @params);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GetConvolutionParameter(GLenum target, GLenum pname, GLint* @params);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Histogram(GLenum target, GLsizei width, GLenum internalformat, GLboolean sink);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GetHistogram(GLenum target, GLboolean reset, GLenum format, GLenum type, GLvoid* values);
    [DllImport(DllName)]
    public static extern unsafe GLvoid ResetHistogram(GLenum target);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GetHistogramParameter(GLenum target, GLenum pname, GLfloat* @params);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GetHistogramParameter(GLenum target, GLenum pname, GLint* @params);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Minmax(GLenum target, GLenum internalformat, GLboolean sink);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GetMinmax(GLenum target, GLboolean reset, GLenum format, GLenum type, GLvoid* values);
    [DllImport(DllName)]
    public static extern unsafe GLvoid ResetMinmax(GLenum target);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GetMinmaxParameter(GLenum target, GLenum pname, GLfloat* @params);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GetMinmaxParameter(GLenum target, GLenum pname, GLint* @params);
    [DllImport(DllName)]
    public static extern unsafe GLvoid DrawPixels(GLsizei width, GLsizei height, GLenum format, GLenum type, GLvoid* pixels);
    [DllImport(DllName)]
    public static extern unsafe GLvoid ClampColor(GLenum target, GLenum clamp);
    [DllImport(DllName)]
    public static extern unsafe GLvoid PixelZoom(GLfloat xfactor, GLfloat yfactor);
    [DllImport(DllName)]
    public static extern unsafe GLvoid Bitmap(GLsizei width, GLsizei height, GLfloat xorig, GLfloat yorig, GLfloat xmove, GLfloat ymove, GLubyte* bitmap);
}