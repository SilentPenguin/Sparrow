using System.Runtime.InteropServices;

public static partial class Gl
{
    [DllImport(DllName, EntryPoint = "glMaterialf")]
    public static extern unsafe void Material(uint face, uint pname, float param);
    [DllImport(DllName, EntryPoint = "glMaterialfv")]
    public static extern unsafe void Material(uint face, uint pname, float* @params);
    [DllImport(DllName, EntryPoint = "glMateriali")]
    public static extern unsafe void Material(uint face, uint pname, int param);
    [DllImport(DllName, EntryPoint = "glMaterialiv")]
    public static extern unsafe void Material(uint face, uint pname, int* @params);
    [DllImport(DllName, EntryPoint = "glLightf")]
    public static extern unsafe void Light(uint light, uint pname, float param);
    [DllImport(DllName, EntryPoint = "glLightfv")]
    public static extern unsafe void Light(uint light, uint pname, float* @params);
    [DllImport(DllName, EntryPoint = "glLighti")]
    public static extern unsafe void Light(uint light, uint pname, int param);
    [DllImport(DllName, EntryPoint = "glLightiv")]
    public static extern unsafe void Light(uint light, uint pname, int* @params);
    [DllImport(DllName, EntryPoint = "glLightModelf")]
    public static extern unsafe void LightModel(uint pname, float param);
    [DllImport(DllName, EntryPoint = "glLightModelfv")]
    public static extern unsafe void LightModel(uint pname, float* @params);
    [DllImport(DllName, EntryPoint = "glLightModeli")]
    public static extern unsafe void LightModel(uint pname, int param);
    [DllImport(DllName, EntryPoint = "glLightModeliv")]
    public static extern unsafe void LightModel(uint pname, int* @params);
    [DllImport(DllName, EntryPoint = "glColorMaterial")]
    public static extern unsafe void ColorMaterial(uint face, uint mode);
    [DllImport(DllName, EntryPoint = "glProvokingVertex")]
    public static extern unsafe void ProvokingVertex(uint mode);
    [DllImport(DllName, EntryPoint = "glShadeModel")]
    public static extern unsafe void ShadeModel(uint mode);
    [DllImport(DllName, EntryPoint = "glGetLightfv")]
    public static extern unsafe void GetLight(uint light, uint pname, float* @params);
    [DllImport(DllName, EntryPoint = "glGetLightiv")]
    public static extern unsafe void GetLight(uint light, uint pname, int* @params);
    [DllImport(DllName, EntryPoint = "glGetMaterialfv")]
    public static extern unsafe void GetMaterial(uint face, uint pname, float* @params);
    [DllImport(DllName, EntryPoint = "glGetMaterialiv")]
    public static extern unsafe void GetMaterial(uint face, uint pname, int* @params);
}