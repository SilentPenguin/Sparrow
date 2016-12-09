using System.Runtime.InteropServices;

public static partial class Gl
{
    [DllImport(DllName, EntryPoint = "glFlush")]
    public static extern unsafe void Flush();
    [DllImport(DllName, EntryPoint = "glFinish")]
    public static extern unsafe void Finish();
    [DllImport(DllName, EntryPoint = "glFenceSync")]
    public static extern unsafe void FenceSync(uint condition, uint flags);
    [DllImport(DllName, EntryPoint = "glDeleteSync")]
    public static extern unsafe void DeleteSync(void* sync);
    [DllImport(DllName, EntryPoint = "glClientWaitSync")]
    public static extern unsafe void ClientWaitSync(void* sync, uint flags, ulong timeout);
    [DllImport(DllName, EntryPoint = "glWaitSync")]
    public static extern unsafe void WaitSync(void* sync, uint flags, ulong timeout);
    [DllImport(DllName, EntryPoint = "glGetSynciv")]
    public static extern unsafe void GetSync(void* sync, uint pname, int bufSize, int* length, int* values);
    [DllImport(DllName, EntryPoint = "glIsSync")]
    public static extern unsafe void IsSync(void* sync);
}