using System.Runtime.InteropServices;

public static partial class Gl
{
    [DllImport(DllName, EntryPoint = "glGetMultisamplefv")]
    public static extern unsafe void GetMultisample(uint pname, uint index, float* val);
    [DllImport(DllName, EntryPoint = "glPointSize")]
    public static extern unsafe void PointSize(float size);
    [DllImport(DllName, EntryPoint = "glPointParameterf")]
    public static extern unsafe void PointParameter(uint pname, float param);
    [DllImport(DllName, EntryPoint = "glPointParameterfv")]
    public static extern unsafe void PointParameter(uint pname, float* @params);
    [DllImport(DllName, EntryPoint = "glPointParameteri")]
    public static extern unsafe void PointParameter(uint pname, int param);
    [DllImport(DllName, EntryPoint = "glPointParameteriv")]
    public static extern unsafe void PointParameter(uint pname, int* @params);
    [DllImport(DllName, EntryPoint = "glLineWidth")]
    public static extern unsafe void LineWidth(float width);
    [DllImport(DllName, EntryPoint = "glLineStipple")]
    public static extern unsafe void LineStipple(int factor, ushort pattern);
    [DllImport(DllName, EntryPoint = "glGetPolygonStipple")]
    public static extern unsafe void GetPolygonStipple(byte* mask);
    [DllImport(DllName, EntryPoint = "glFrontFace")]
    public static extern unsafe void FrontFace(uint mode);
    [DllImport(DllName, EntryPoint = "glCullFace")]
    public static extern unsafe void CullFace(uint mode);
    [DllImport(DllName, EntryPoint = "glPolygonMode")]
    public static extern unsafe void PolygonMode(uint face, uint mode);
    [DllImport(DllName, EntryPoint = "glPolygonOffset")]
    public static extern unsafe void PolygonOffset(float factor, float units);
    [DllImport(DllName, EntryPoint = "glPixelStoref")]
    public static extern unsafe void PixelStore(uint pname, float param);
    [DllImport(DllName, EntryPoint = "glPixelStorei")]
    public static extern unsafe void PixelStore(uint pname, int param);
    [DllImport(DllName, EntryPoint = "glPixelMapfv")]
    public static extern unsafe void PixelMap(uint map, int mapsize, float* values);
    [DllImport(DllName, EntryPoint = "glPixelMapuiv")]
    public static extern unsafe void PixelMap(uint map, int mapsize, uint* values);
    [DllImport(DllName, EntryPoint = "glPixelMapusv")]
    public static extern unsafe void PixelMap(uint map, int mapsize, ushort* values);
    [DllImport(DllName, EntryPoint = "glGetPixelMapfv")]
    public static extern unsafe void GetPixelMap(uint map, float* values);
    [DllImport(DllName, EntryPoint = "glGetPixelMapuiv")]
    public static extern unsafe void GetPixelMap(uint map, uint* values);
    [DllImport(DllName, EntryPoint = "glGetPixelMapusv")]
    public static extern unsafe void GetPixelMap(uint map, ushort* values);
    [DllImport(DllName, EntryPoint = "glColorTable")]
    public static extern unsafe void ColorTable(uint target, uint internalformat, int width, uint format, uint type, void* table);
    [DllImport(DllName, EntryPoint = "glColorTableParameterfv")]
    public static extern unsafe void ColorTableParameter(uint target, uint pname, float* @params);
    [DllImport(DllName, EntryPoint = "glColorTableParameteriv")]
    public static extern unsafe void ColorTableParameter(uint target, uint pname, int* @params);
    [DllImport(DllName, EntryPoint = "glCopyColorTable")]
    public static extern unsafe void CopyColorTable(uint target, uint internalformat, int x, int y, int width);
    [DllImport(DllName, EntryPoint = "glColorSubTable")]
    public static extern unsafe void ColorSubTable(uint target, int start, int count, uint format, uint type, void* data);
    [DllImport(DllName, EntryPoint = "glCopyColorSubTable")]
    public static extern unsafe void CopyColorSubTable(uint target, int start, int x, int y, int width);
    [DllImport(DllName, EntryPoint = "glGetColorTable")]
    public static extern unsafe void GetColorTable(uint target, uint format, uint type, void* table);
    [DllImport(DllName, EntryPoint = "glGetColorTableParameterfv")]
    public static extern unsafe void GetColorTableParameter(uint target, uint pname, float* @params);
    [DllImport(DllName, EntryPoint = "glGetColorTableParameteriv")]
    public static extern unsafe void GetColorTableParameter(uint target, uint pname, int* @params);
    [DllImport(DllName, EntryPoint = "glConvolutionFilter1D")]
    public static extern unsafe void ConvolutionFilter1D(uint target, uint internalformat, int width, uint format, uint type, void* image);
    [DllImport(DllName, EntryPoint = "glConvolutionFilter2D")]
    public static extern unsafe void ConvolutionFilter2D(uint target, uint internalformat, int width, int height, uint format, uint type, void* image);
    [DllImport(DllName, EntryPoint = "glConvolutionParameterf")]
    public static extern unsafe void ConvolutionParameter(uint target, uint pname, float @params);
    [DllImport(DllName, EntryPoint = "glConvolutionParameterfv")]
    public static extern unsafe void ConvolutionParameter(uint target, uint pname, float* @params);
    [DllImport(DllName, EntryPoint = "glConvolutionParameteri")]
    public static extern unsafe void ConvolutionParameter(uint target, uint pname, int @params);
    [DllImport(DllName, EntryPoint = "glConvolutionParameteriv")]
    public static extern unsafe void ConvolutionParameter(uint target, uint pname, int* @params);
    [DllImport(DllName, EntryPoint = "glSeparableFilter2D")]
    public static extern unsafe void SeparableFilter2D(uint target, uint internalformat, int width, int height, uint format, uint type, void* row, void* column);
    [DllImport(DllName, EntryPoint = "glCopyConvolutionFilter1D")]
    public static extern unsafe void CopyConvolutionFilter1D(uint target, uint internalformat, int x, int y, int width);
    [DllImport(DllName, EntryPoint = "glCopyConvolutionFilter2D")]
    public static extern unsafe void CopyConvolutionFilter2D(uint target, uint internalformat, int x, int y, int width, int height);
    [DllImport(DllName, EntryPoint = "glGetConvolutionFilter")]
    public static extern unsafe void GetConvolutionFilter(uint target, uint format, uint type, void* image);
    [DllImport(DllName, EntryPoint = "glGetSeparableFilter")]
    public static extern unsafe void GetSeparableFilter(uint target, uint format, uint type, void* row, void* column, void* span);
    [DllImport(DllName, EntryPoint = "glGetConvolutionParameterfv")]
    public static extern unsafe void GetConvolutionParameter(uint target, uint pname, float* @params);
    [DllImport(DllName, EntryPoint = "glGetConvolutionParameteriv")]
    public static extern unsafe void GetConvolutionParameter(uint target, uint pname, int* @params);
    [DllImport(DllName, EntryPoint = "glHistogram")]
    public static extern unsafe void Histogram(uint target, int width, uint internalformat, bool sink);
    [DllImport(DllName, EntryPoint = "glGetHistogram")]
    public static extern unsafe void GetHistogram(uint target, bool reset, uint format, uint type, void* values);
    [DllImport(DllName, EntryPoint = "glResetHistogram")]
    public static extern unsafe void ResetHistogram(uint target);
    [DllImport(DllName, EntryPoint = "glGetHistogramParameterfv")]
    public static extern unsafe void GetHistogramParameter(uint target, uint pname, float* @params);
    [DllImport(DllName, EntryPoint = "glGetHistogramParameteriv")]
    public static extern unsafe void GetHistogramParameter(uint target, uint pname, int* @params);
    [DllImport(DllName, EntryPoint = "glMinmax")]
    public static extern unsafe void Minmax(uint target, uint internalformat, bool sink);
    [DllImport(DllName, EntryPoint = "glGetMinmax")]
    public static extern unsafe void GetMinmax(uint target, bool reset, uint format, uint type, void* values);
    [DllImport(DllName, EntryPoint = "glResetMinmax")]
    public static extern unsafe void ResetMinmax(uint target);
    [DllImport(DllName, EntryPoint = "glGetMinmaxParameterfv")]
    public static extern unsafe void GetMinmaxParameter(uint target, uint pname, float* @params);
    [DllImport(DllName, EntryPoint = "glGetMinmaxParameteriv")]
    public static extern unsafe void GetMinmaxParameter(uint target, uint pname, int* @params);
    [DllImport(DllName, EntryPoint = "glDrawPixels")]
    public static extern unsafe void DrawPixels(int width, int height, uint format, uint type, void* pixels);
    [DllImport(DllName, EntryPoint = "glClampColor")]
    public static extern unsafe void ClampColor(uint target, uint clamp);
    [DllImport(DllName, EntryPoint = "glPixelZoom")]
    public static extern unsafe void PixelZoom(float xfactor, float yfactor);
    [DllImport(DllName, EntryPoint = "glBitmap")]
    public static extern unsafe void Bitmap(int width, int height, float xorig, float yorig, float xmove, float ymove, byte* bitmap);
}