using System.Runtime.InteropServices;

public static partial class Gl
{
    [DllImport(DllName, EntryPoint = "glReadPixels")]
    public static extern unsafe void ReadPixels(int x, int y, int width, int height, uint format, uint type, void* pixels);
    [DllImport(DllName, EntryPoint = "glReadBuffer")]
    public static extern unsafe void ReadBuffer(uint src);
    [DllImport(DllName, EntryPoint = "glCopyPixels")]
    public static extern unsafe void CopyPixels(int x, int y, int width, int height, uint type);
    [DllImport(DllName, EntryPoint = "glBlitFramebuffer")]
    public static extern unsafe void BlitFramebuffer(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter);
}