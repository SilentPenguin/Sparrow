using System.Runtime.InteropServices;

public static partial class Gl
{
    [DllImport(DllName, EntryPoint = "glFogf")]
    public static extern unsafe void Fog(uint pname, float param);
    [DllImport(DllName, EntryPoint = "glFogfv")]
    public static extern unsafe void Fog(uint pname, float* @params);
    [DllImport(DllName, EntryPoint = "glFogi")]
    public static extern unsafe void Fog(uint pname, int param);
    [DllImport(DllName, EntryPoint = "glFogiv")]
    public static extern unsafe void Fog(uint pname, int* @params);
    [DllImport(DllName, EntryPoint = "glHint")]
    public static extern unsafe void Hint(uint target, uint mode);
}