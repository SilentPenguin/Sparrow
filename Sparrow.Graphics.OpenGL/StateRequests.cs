using System.Runtime.InteropServices;

public static partial class Gl
{
    [DllImport(DllName, EntryPoint = "glGetBooleanv")]
    public static extern unsafe void GetBoolean(uint pname, bool* data);
    [DllImport(DllName, EntryPoint = "glGetBooleani_v")]
    public static extern unsafe void GetBoolean(uint target, uint index, bool* data);
    [DllImport(DllName, EntryPoint = "glGetInteger64v")]
    public static extern unsafe void GetInteger(uint pname, long* data);
    [DllImport(DllName, EntryPoint = "glGetIntegerv")]
    public static extern unsafe void GetInteger(uint pname, int* data);
    [DllImport(DllName, EntryPoint = "glGetIntegeri_v")]
    public static extern unsafe void GetInteger(uint target, uint index, int* data);
    [DllImport(DllName, EntryPoint = "glGetFloatv")]
    public static extern unsafe void GetFloat(uint pname, float* data);
    [DllImport(DllName, EntryPoint = "glGetDoublev")]
    public static extern unsafe void GetDouble(uint pname, double* data);
    [DllImport(DllName, EntryPoint = "glIsEnabled")]
    public static extern unsafe void IsEnabled(uint cap);
    [DllImport(DllName, EntryPoint = "glIsEnabledi")]
    public static extern unsafe void IsEnabled(uint target, uint index);
    [DllImport(DllName, EntryPoint = "glGetPointerv")]
    public static extern unsafe void GetPointer(uint pname, void** @params);
    [DllImport(DllName, EntryPoint = "glGetString")]
    public static extern unsafe void GetString(uint name);
    [DllImport(DllName, EntryPoint = "glGetStringi")]
    public static extern unsafe void GetString(uint name, uint index);
}