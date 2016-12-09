using System.Runtime.InteropServices;

public static partial class Gl
{
    [DllImport(DllName, EntryPoint = "glDepthRange")]
    public static extern unsafe void DepthRange(double near, double far);
    [DllImport(DllName, EntryPoint = "glViewport")]
    public static extern unsafe void Viewport(int x, int y, int width, int height);
    [DllImport(DllName, EntryPoint = "glClipPlane")]
    public static extern unsafe void ClipPlane(uint plane, double* equation);
}