using System.Runtime.InteropServices;

public static partial class Gl
{
    [DllImport(DllName, EntryPoint = "glRectd")]
    public static extern unsafe void Rect(double x1, double y1, double x2, double y2);
    [DllImport(DllName, EntryPoint = "glRectdv")]
    public static extern unsafe void Rect(double* v1, double* v2);
    [DllImport(DllName, EntryPoint = "glRectf")]
    public static extern unsafe void Rect(float x1, float y1, float x2, float y2);
    [DllImport(DllName, EntryPoint = "glRectfv")]
    public static extern unsafe void Rect(float* v1, float* v2);
    [DllImport(DllName, EntryPoint = "glRecti")]
    public static extern unsafe void Rect(int x1, int y1, int x2, int y2);
    [DllImport(DllName, EntryPoint = "glRectiv")]
    public static extern unsafe void Rect(int* v1, int* v2);
    [DllImport(DllName, EntryPoint = "glRects")]
    public static extern unsafe void Rect(short x1, short y1, short x2, short y2);
    [DllImport(DllName, EntryPoint = "glRectsv")]
    public static extern unsafe void Rect(short* v1, short* v2);
    [DllImport(DllName, EntryPoint = "glMatrixMode")]
    public static extern unsafe void MatrixMode(uint mode);
    [DllImport(DllName, EntryPoint = "glLoadMatrixd")]
    public static extern unsafe void LoadMatrix(double* m);
    [DllImport(DllName, EntryPoint = "glLoadMatrixf")]
    public static extern unsafe void LoadMatrix(float* m);
    [DllImport(DllName, EntryPoint = "glLoadTransposeMatrixd")]
    public static extern unsafe void LoadTransposeMatrix(double* m);
    [DllImport(DllName, EntryPoint = "glLoadTransposeMatrixf")]
    public static extern unsafe void LoadTransposeMatrix(float* m);
    [DllImport(DllName, EntryPoint = "glLoadIdentity")]
    public static extern unsafe void LoadIdentity();
    [DllImport(DllName, EntryPoint = "glRotated")]
    public static extern unsafe void Rotate(double angle, double x, double y, double z);
    [DllImport(DllName, EntryPoint = "glRotatef")]
    public static extern unsafe void Rotate(float angle, float x, float y, float z);
    [DllImport(DllName, EntryPoint = "glLoadMatrixd")]
    public static extern unsafe void LoadMatrix(double* m);
    [DllImport(DllName, EntryPoint = "glLoadMatrixf")]
    public static extern unsafe void LoadMatrix(float* m);
    [DllImport(DllName, EntryPoint = "glTranslated")]
    public static extern unsafe void Translate(double x, double y, double z);
    [DllImport(DllName, EntryPoint = "glTranslatef")]
    public static extern unsafe void Translate(float x, float y, float z);
    [DllImport(DllName, EntryPoint = "glScaled")]
    public static extern unsafe void Scale(double x, double y, double z);
    [DllImport(DllName, EntryPoint = "glScalef")]
    public static extern unsafe void Scale(float x, float y, float z);
    [DllImport(DllName, EntryPoint = "glOrtho")]
    public static extern unsafe void Ortho(double left, double right, double bottom, double top, double zNear, double zFar);
    [DllImport(DllName, EntryPoint = "glPushMatrix")]
    public static extern unsafe void PushMatrix();
    [DllImport(DllName, EntryPoint = "glPopMatrix")]
    public static extern unsafe void PopMatrix();
    [DllImport(DllName, EntryPoint = "glTexGend")]
    public static extern unsafe void TexGen(uint coord, uint pname, double param);
    [DllImport(DllName, EntryPoint = "glTexGendv")]
    public static extern unsafe void TexGen(uint coord, uint pname, double* @params);
    [DllImport(DllName, EntryPoint = "glTexGenf")]
    public static extern unsafe void TexGen(uint coord, uint pname, float param);
    [DllImport(DllName, EntryPoint = "glTexGenfv")]
    public static extern unsafe void TexGen(uint coord, uint pname, float* @params);
    [DllImport(DllName, EntryPoint = "glTexGeni")]
    public static extern unsafe void TexGen(uint coord, uint pname, int param);
    [DllImport(DllName, EntryPoint = "glTexGeniv")]
    public static extern unsafe void TexGen(uint coord, uint pname, int* @params);
}