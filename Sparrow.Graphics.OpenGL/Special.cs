using System.Runtime.InteropServices;

public static partial class Gl
{
    [DllImport(DllName, EntryPoint = "glMap1d")]
    public static extern unsafe void Map1(uint target, double u1, double u2, int stride, int order, double* points);
    [DllImport(DllName, EntryPoint = "glMap1f")]
    public static extern unsafe void Map1(uint target, float u1, float u2, int stride, int order, float* points);
    [DllImport(DllName, EntryPoint = "glMap2d")]
    public static extern unsafe void Map2(uint target, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double* points);
    [DllImport(DllName, EntryPoint = "glMap2f")]
    public static extern unsafe void Map2(uint target, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, float* points);
    [DllImport(DllName, EntryPoint = "glEvalCoord1d")]
    public static extern unsafe void EvalCoord1(double u);
    [DllImport(DllName, EntryPoint = "glEvalCoord1dv")]
    public static extern unsafe void EvalCoord1(double* u);
    [DllImport(DllName, EntryPoint = "glEvalCoord1f")]
    public static extern unsafe void EvalCoord1(float u);
    [DllImport(DllName, EntryPoint = "glEvalCoord1fv")]
    public static extern unsafe void EvalCoord1(float* u);
    [DllImport(DllName, EntryPoint = "glEvalCoord2d")]
    public static extern unsafe void EvalCoord2(double u, double v);
    [DllImport(DllName, EntryPoint = "glEvalCoord2dv")]
    public static extern unsafe void EvalCoord2(double* u);
    [DllImport(DllName, EntryPoint = "glEvalCoord2f")]
    public static extern unsafe void EvalCoord2(float u, float v);
    [DllImport(DllName, EntryPoint = "glEvalCoord2fv")]
    public static extern unsafe void EvalCoord2(float* u);
    [DllImport(DllName, EntryPoint = "glMapGrid1d")]
    public static extern unsafe void MapGrid1(int un, double u1, double u2);
    [DllImport(DllName, EntryPoint = "glMapGrid1f")]
    public static extern unsafe void MapGrid1(int un, float u1, float u2);
    [DllImport(DllName, EntryPoint = "glMapGrid2d")]
    public static extern unsafe void MapGrid2(int un, double u1, double u2, int vn, double v1, double v2);
    [DllImport(DllName, EntryPoint = "glMapGrid2f")]
    public static extern unsafe void MapGrid2(int un, float u1, float u2, int vn, float v1, float v2);
    [DllImport(DllName, EntryPoint = "glEvalMesh1")]
    public static extern unsafe void EvalMesh1(uint mode, int i1, int i2);
    [DllImport(DllName, EntryPoint = "glEvalMesh2")]
    public static extern unsafe void EvalMesh2(uint mode, int i1, int i2, int j1, int j2);
    [DllImport(DllName, EntryPoint = "glEvalPoint1")]
    public static extern unsafe void EvalPoint1(int i);
    [DllImport(DllName, EntryPoint = "glEvalPoint2")]
    public static extern unsafe void EvalPoint2(int i, int j);
    [DllImport(DllName, EntryPoint = "glGetMapdv")]
    public static extern unsafe void GetMap(uint target, uint query, double* v);
    [DllImport(DllName, EntryPoint = "glGetMapfv")]
    public static extern unsafe void GetMap(uint target, uint query, float* v);
    [DllImport(DllName, EntryPoint = "glGetMapiv")]
    public static extern unsafe void GetMap(uint target, uint query, int* v);
    [DllImport(DllName, EntryPoint = "glInitNames")]
    public static extern unsafe void InitNames();
    [DllImport(DllName, EntryPoint = "glPopName")]
    public static extern unsafe void PopName();
    [DllImport(DllName, EntryPoint = "glPushName")]
    public static extern unsafe void PushName(uint name);
    [DllImport(DllName, EntryPoint = "glLoadName")]
    public static extern unsafe void LoadName(uint name);
    [DllImport(DllName, EntryPoint = "glRenderMode")]
    public static extern unsafe void RenderMode(uint mode);
    [DllImport(DllName, EntryPoint = "glSelectBuffer")]
    public static extern unsafe void SelectBuffer(int size, uint* buffer);
    [DllImport(DllName, EntryPoint = "glFeedbackBuffer")]
    public static extern unsafe void FeedbackBuffer(int size, uint type, float* buffer);
    [DllImport(DllName, EntryPoint = "glPassThrough")]
    public static extern unsafe void PassThrough(float token);
    [DllImport(DllName, EntryPoint = "glNewList")]
    public static extern unsafe void NewList(uint list, uint mode);
    [DllImport(DllName, EntryPoint = "glEndList")]
    public static extern unsafe void EndList();
    [DllImport(DllName, EntryPoint = "glCallList")]
    public static extern unsafe void CallList(uint list);
    [DllImport(DllName, EntryPoint = "glCallLists")]
    public static extern unsafe void CallLists(int n, uint type, void* lists);
    [DllImport(DllName, EntryPoint = "glListBase")]
    public static extern unsafe void ListBase(uint @base);
    [DllImport(DllName, EntryPoint = "glGenLists")]
    public static extern unsafe void GenLists(int range);
    [DllImport(DllName, EntryPoint = "glIsList")]
    public static extern unsafe void IsList(uint list);
    [DllImport(DllName, EntryPoint = "glDeleteLists")]
    public static extern unsafe void DeleteLists(uint list, int range);
}