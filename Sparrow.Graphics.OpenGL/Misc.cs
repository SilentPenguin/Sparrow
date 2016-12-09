using System.Runtime.InteropServices;

public static partial class Gl
{
    [DllImport(DllName, EntryPoint = "glEnable")]
    public static extern unsafe void Enable(uint cap);
    [DllImport(DllName, EntryPoint = "glEnablei")]
    public static extern unsafe void Enable(uint target, uint index);
    [DllImport(DllName, EntryPoint = "glDisable")]
    public static extern unsafe void Disable(uint cap);
    [DllImport(DllName, EntryPoint = "glDisablei")]
    public static extern unsafe void Disable(uint target, uint index);
    [DllImport(DllName, EntryPoint = "glGetError")]
    public static extern unsafe void GetError();
}