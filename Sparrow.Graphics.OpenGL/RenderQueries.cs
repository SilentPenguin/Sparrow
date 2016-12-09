using System.Runtime.InteropServices;

public static partial class Gl
{
    [DllImport(DllName, EntryPoint = "glBeginConditionalRender")]
    public static extern unsafe void BeginConditionalRender(uint id, uint mode);
    [DllImport(DllName, EntryPoint = "glEndConditionalRender")]
    public static extern unsafe void EndConditionalRender();
    [DllImport(DllName, EntryPoint = "glBeginTransformFeedback")]
    public static extern unsafe void BeginTransformFeedback(uint primitiveMode);
    [DllImport(DllName, EntryPoint = "glEndTransformFeedback")]
    public static extern unsafe void EndTransformFeedback();
    [DllImport(DllName, EntryPoint = "glRasterPos2d")]
    public static extern unsafe void RasterPos2(double x, double y);
    [DllImport(DllName, EntryPoint = "glRasterPos2dv")]
    public static extern unsafe void RasterPos2(double* v);
    [DllImport(DllName, EntryPoint = "glRasterPos2f")]
    public static extern unsafe void RasterPos2(float x, float y);
    [DllImport(DllName, EntryPoint = "glRasterPos2fv")]
    public static extern unsafe void RasterPos2(float* v);
    [DllImport(DllName, EntryPoint = "glRasterPos2i")]
    public static extern unsafe void RasterPos2(int x, int y);
    [DllImport(DllName, EntryPoint = "glRasterPos2iv")]
    public static extern unsafe void RasterPos2(int* v);
    [DllImport(DllName, EntryPoint = "glRasterPos2s")]
    public static extern unsafe void RasterPos2(short x, short y);
    [DllImport(DllName, EntryPoint = "glRasterPos2sv")]
    public static extern unsafe void RasterPos2(short* v);
    [DllImport(DllName, EntryPoint = "glRasterPos3d")]
    public static extern unsafe void RasterPos3(double x, double y, double z);
    [DllImport(DllName, EntryPoint = "glRasterPos3dv")]
    public static extern unsafe void RasterPos3(double* v);
    [DllImport(DllName, EntryPoint = "glRasterPos3f")]
    public static extern unsafe void RasterPos3(float x, float y, float z);
    [DllImport(DllName, EntryPoint = "glRasterPos3fv")]
    public static extern unsafe void RasterPos3(float* v);
    [DllImport(DllName, EntryPoint = "glRasterPos3i")]
    public static extern unsafe void RasterPos3(int x, int y, int z);
    [DllImport(DllName, EntryPoint = "glRasterPos3iv")]
    public static extern unsafe void RasterPos3(int* v);
    [DllImport(DllName, EntryPoint = "glRasterPos3s")]
    public static extern unsafe void RasterPos3(short x, short y, short z);
    [DllImport(DllName, EntryPoint = "glRasterPos3sv")]
    public static extern unsafe void RasterPos3(short* v);
    [DllImport(DllName, EntryPoint = "glRasterPos4d")]
    public static extern unsafe void RasterPos4(double x, double y, double z, double w);
    [DllImport(DllName, EntryPoint = "glRasterPos4dv")]
    public static extern unsafe void RasterPos4(double* v);
    [DllImport(DllName, EntryPoint = "glRasterPos4f")]
    public static extern unsafe void RasterPos4(float x, float y, float z, float w);
    [DllImport(DllName, EntryPoint = "glRasterPos4fv")]
    public static extern unsafe void RasterPos4(float* v);
    [DllImport(DllName, EntryPoint = "glRasterPos4i")]
    public static extern unsafe void RasterPos4(int x, int y, int z, int w);
    [DllImport(DllName, EntryPoint = "glRasterPos4iv")]
    public static extern unsafe void RasterPos4(int* v);
    [DllImport(DllName, EntryPoint = "glRasterPos4s")]
    public static extern unsafe void RasterPos4(short x, short y, short z, short w);
    [DllImport(DllName, EntryPoint = "glRasterPos4sv")]
    public static extern unsafe void RasterPos4(short* v);
    [DllImport(DllName, EntryPoint = "glWindowPos2d")]
    public static extern unsafe void WindowPos2(double x, double y);
    [DllImport(DllName, EntryPoint = "glWindowPos2dv")]
    public static extern unsafe void WindowPos2(double* v);
    [DllImport(DllName, EntryPoint = "glWindowPos2f")]
    public static extern unsafe void WindowPos2(float x, float y);
    [DllImport(DllName, EntryPoint = "glWindowPos2fv")]
    public static extern unsafe void WindowPos2(float* v);
    [DllImport(DllName, EntryPoint = "glWindowPos2i")]
    public static extern unsafe void WindowPos2(int x, int y);
    [DllImport(DllName, EntryPoint = "glWindowPos2iv")]
    public static extern unsafe void WindowPos2(int* v);
    [DllImport(DllName, EntryPoint = "glWindowPos2s")]
    public static extern unsafe void WindowPos2(short x, short y);
    [DllImport(DllName, EntryPoint = "glWindowPos2sv")]
    public static extern unsafe void WindowPos2(short* v);
    [DllImport(DllName, EntryPoint = "glWindowPos3d")]
    public static extern unsafe void WindowPos3(double x, double y, double z);
    [DllImport(DllName, EntryPoint = "glWindowPos3dv")]
    public static extern unsafe void WindowPos3(double* v);
    [DllImport(DllName, EntryPoint = "glWindowPos3f")]
    public static extern unsafe void WindowPos3(float x, float y, float z);
    [DllImport(DllName, EntryPoint = "glWindowPos3fv")]
    public static extern unsafe void WindowPos3(float* v);
    [DllImport(DllName, EntryPoint = "glWindowPos3i")]
    public static extern unsafe void WindowPos3(int x, int y, int z);
    [DllImport(DllName, EntryPoint = "glWindowPos3iv")]
    public static extern unsafe void WindowPos3(int* v);
    [DllImport(DllName, EntryPoint = "glWindowPos3s")]
    public static extern unsafe void WindowPos3(short x, short y, short z);
    [DllImport(DllName, EntryPoint = "glWindowPos3sv")]
    public static extern unsafe void WindowPos3(short* v);
    [DllImport(DllName, EntryPoint = "glBeginQuery")]
    public static extern unsafe void BeginQuery(uint target, uint id);
    [DllImport(DllName, EntryPoint = "glEndQuery")]
    public static extern unsafe void EndQuery(uint target);
    [DllImport(DllName, EntryPoint = "glGenQueries")]
    public static extern unsafe void GenQueries(int n, uint* ids);
    [DllImport(DllName, EntryPoint = "glDeleteQueries")]
    public static extern unsafe void DeleteQueries(int n, uint* ids);
    [DllImport(DllName, EntryPoint = "glIsQuery")]
    public static extern unsafe void IsQuery(uint id);
    [DllImport(DllName, EntryPoint = "glGetQueryiv")]
    public static extern unsafe void GetQuery(uint target, uint pname, int* @params);
    [DllImport(DllName, EntryPoint = "glGetQueryObjectiv")]
    public static extern unsafe void GetQueryObject(uint id, uint pname, int* @params);
    [DllImport(DllName, EntryPoint = "glGetQueryObjectuiv")]
    public static extern unsafe void GetQueryObject(uint id, uint pname, uint* @params);
}