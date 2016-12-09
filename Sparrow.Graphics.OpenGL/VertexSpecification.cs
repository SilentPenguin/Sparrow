using System.Runtime.InteropServices;

public static partial class Gl
{
    [DllImport(DllName, EntryPoint = "glBegin")]
    public static extern unsafe void Begin(uint mode);
    [DllImport(DllName, EntryPoint = "glEnd")]
    public static extern unsafe void End();
    [DllImport(DllName, EntryPoint = "glEdgeFlag")]
    public static extern unsafe void EdgeFlag(bool flag);
    [DllImport(DllName, EntryPoint = "glEdgeFlagv")]
    public static extern unsafe void EdgeFlag(bool* flag);
    [DllImport(DllName, EntryPoint = "glVertex2d")]
    public static extern unsafe void Vertex2(double x, double y);
    [DllImport(DllName, EntryPoint = "glVertex2dv")]
    public static extern unsafe void Vertex2(double* v);
    [DllImport(DllName, EntryPoint = "glVertex2f")]
    public static extern unsafe void Vertex2(float x, float y);
    [DllImport(DllName, EntryPoint = "glVertex2fv")]
    public static extern unsafe void Vertex2(float* v);
    [DllImport(DllName, EntryPoint = "glVertex2i")]
    public static extern unsafe void Vertex2(int x, int y);
    [DllImport(DllName, EntryPoint = "glVertex2iv")]
    public static extern unsafe void Vertex2(int* v);
    [DllImport(DllName, EntryPoint = "glVertex2s")]
    public static extern unsafe void Vertex2(short x, short y);
    [DllImport(DllName, EntryPoint = "glVertex2sv")]
    public static extern unsafe void Vertex2(short* v);
    [DllImport(DllName, EntryPoint = "glVertex3d")]
    public static extern unsafe void Vertex3(double x, double y, double z);
    [DllImport(DllName, EntryPoint = "glVertex3dv")]
    public static extern unsafe void Vertex3(double* v);
    [DllImport(DllName, EntryPoint = "glVertex3f")]
    public static extern unsafe void Vertex3(float x, float y, float z);
    [DllImport(DllName, EntryPoint = "glVertex3fv")]
    public static extern unsafe void Vertex3(float* v);
    [DllImport(DllName, EntryPoint = "glVertex3i")]
    public static extern unsafe void Vertex3(int x, int y, int z);
    [DllImport(DllName, EntryPoint = "glVertex3iv")]
    public static extern unsafe void Vertex3(int* v);
    [DllImport(DllName, EntryPoint = "glVertex3s")]
    public static extern unsafe void Vertex3(short x, short y, short z);
    [DllImport(DllName, EntryPoint = "glVertex3sv")]
    public static extern unsafe void Vertex3(short* v);
    [DllImport(DllName, EntryPoint = "glVertex4d")]
    public static extern unsafe void Vertex4(double x, double y, double z, double w);
    [DllImport(DllName, EntryPoint = "glVertex4dv")]
    public static extern unsafe void Vertex4(double* v);
    [DllImport(DllName, EntryPoint = "glVertex4f")]
    public static extern unsafe void Vertex4(float x, float y, float z, float w);
    [DllImport(DllName, EntryPoint = "glVertex4fv")]
    public static extern unsafe void Vertex4(float* v);
    [DllImport(DllName, EntryPoint = "glVertex4i")]
    public static extern unsafe void Vertex4(int x, int y, int z, int w);
    [DllImport(DllName, EntryPoint = "glVertex4iv")]
    public static extern unsafe void Vertex4(int* v);
    [DllImport(DllName, EntryPoint = "glVertex4s")]
    public static extern unsafe void Vertex4(short x, short y, short z, short w);
    [DllImport(DllName, EntryPoint = "glVertex4sv")]
    public static extern unsafe void Vertex4(short* v);
    [DllImport(DllName, EntryPoint = "glTexCoord1d")]
    public static extern unsafe void TexCoord1(double s);
    [DllImport(DllName, EntryPoint = "glTexCoord1dv")]
    public static extern unsafe void TexCoord1(double* v);
    [DllImport(DllName, EntryPoint = "glTexCoord1f")]
    public static extern unsafe void TexCoord1(float s);
    [DllImport(DllName, EntryPoint = "glTexCoord1fv")]
    public static extern unsafe void TexCoord1(float* v);
    [DllImport(DllName, EntryPoint = "glTexCoord1i")]
    public static extern unsafe void TexCoord1(int s);
    [DllImport(DllName, EntryPoint = "glTexCoord1iv")]
    public static extern unsafe void TexCoord1(int* v);
    [DllImport(DllName, EntryPoint = "glTexCoord1s")]
    public static extern unsafe void TexCoord1(short s);
    [DllImport(DllName, EntryPoint = "glTexCoord1sv")]
    public static extern unsafe void TexCoord1(short* v);
    [DllImport(DllName, EntryPoint = "glTexCoord2d")]
    public static extern unsafe void TexCoord2(double s, double t);
    [DllImport(DllName, EntryPoint = "glTexCoord2dv")]
    public static extern unsafe void TexCoord2(double* v);
    [DllImport(DllName, EntryPoint = "glTexCoord2f")]
    public static extern unsafe void TexCoord2(float s, float t);
    [DllImport(DllName, EntryPoint = "glTexCoord2fv")]
    public static extern unsafe void TexCoord2(float* v);
    [DllImport(DllName, EntryPoint = "glTexCoord2i")]
    public static extern unsafe void TexCoord2(int s, int t);
    [DllImport(DllName, EntryPoint = "glTexCoord2iv")]
    public static extern unsafe void TexCoord2(int* v);
    [DllImport(DllName, EntryPoint = "glTexCoord2s")]
    public static extern unsafe void TexCoord2(short s, short t);
    [DllImport(DllName, EntryPoint = "glTexCoord2sv")]
    public static extern unsafe void TexCoord2(short* v);
    [DllImport(DllName, EntryPoint = "glTexCoord3d")]
    public static extern unsafe void TexCoord3(double s, double t, double r);
    [DllImport(DllName, EntryPoint = "glTexCoord3dv")]
    public static extern unsafe void TexCoord3(double* v);
    [DllImport(DllName, EntryPoint = "glTexCoord3f")]
    public static extern unsafe void TexCoord3(float s, float t, float r);
    [DllImport(DllName, EntryPoint = "glTexCoord3fv")]
    public static extern unsafe void TexCoord3(float* v);
    [DllImport(DllName, EntryPoint = "glTexCoord3i")]
    public static extern unsafe void TexCoord3(int s, int t, int r);
    [DllImport(DllName, EntryPoint = "glTexCoord3iv")]
    public static extern unsafe void TexCoord3(int* v);
    [DllImport(DllName, EntryPoint = "glTexCoord3s")]
    public static extern unsafe void TexCoord3(short s, short t, short r);
    [DllImport(DllName, EntryPoint = "glTexCoord3sv")]
    public static extern unsafe void TexCoord3(short* v);
    [DllImport(DllName, EntryPoint = "glTexCoord4d")]
    public static extern unsafe void TexCoord4(double s, double t, double r, double q);
    [DllImport(DllName, EntryPoint = "glTexCoord4dv")]
    public static extern unsafe void TexCoord4(double* v);
    [DllImport(DllName, EntryPoint = "glTexCoord4f")]
    public static extern unsafe void TexCoord4(float s, float t, float r, float q);
    [DllImport(DllName, EntryPoint = "glTexCoord4fv")]
    public static extern unsafe void TexCoord4(float* v);
    [DllImport(DllName, EntryPoint = "glTexCoord4i")]
    public static extern unsafe void TexCoord4(int s, int t, int r, int q);
    [DllImport(DllName, EntryPoint = "glTexCoord4iv")]
    public static extern unsafe void TexCoord4(int* v);
    [DllImport(DllName, EntryPoint = "glTexCoord4s")]
    public static extern unsafe void TexCoord4(short s, short t, short r, short q);
    [DllImport(DllName, EntryPoint = "glTexCoord4sv")]
    public static extern unsafe void TexCoord4(short* v);
    [DllImport(DllName, EntryPoint = "glMultiTexCoord1d")]
    public static extern unsafe void MultiTexCoord1(uint target, double s);
    [DllImport(DllName, EntryPoint = "glMultiTexCoord1dv")]
    public static extern unsafe void MultiTexCoord1(uint target, double* v);
    [DllImport(DllName, EntryPoint = "glMultiTexCoord1f")]
    public static extern unsafe void MultiTexCoord1(uint target, float s);
    [DllImport(DllName, EntryPoint = "glMultiTexCoord1fv")]
    public static extern unsafe void MultiTexCoord1(uint target, float* v);
    [DllImport(DllName, EntryPoint = "glMultiTexCoord1i")]
    public static extern unsafe void MultiTexCoord1(uint target, int s);
    [DllImport(DllName, EntryPoint = "glMultiTexCoord1iv")]
    public static extern unsafe void MultiTexCoord1(uint target, int* v);
    [DllImport(DllName, EntryPoint = "glMultiTexCoord1s")]
    public static extern unsafe void MultiTexCoord1(uint target, short s);
    [DllImport(DllName, EntryPoint = "glMultiTexCoord1sv")]
    public static extern unsafe void MultiTexCoord1(uint target, short* v);
    [DllImport(DllName, EntryPoint = "glMultiTexCoord2d")]
    public static extern unsafe void MultiTexCoord2(uint target, double s, double t);
    [DllImport(DllName, EntryPoint = "glMultiTexCoord2dv")]
    public static extern unsafe void MultiTexCoord2(uint target, double* v);
    [DllImport(DllName, EntryPoint = "glMultiTexCoord2f")]
    public static extern unsafe void MultiTexCoord2(uint target, float s, float t);
    [DllImport(DllName, EntryPoint = "glMultiTexCoord2fv")]
    public static extern unsafe void MultiTexCoord2(uint target, float* v);
    [DllImport(DllName, EntryPoint = "glMultiTexCoord2i")]
    public static extern unsafe void MultiTexCoord2(uint target, int s, int t);
    [DllImport(DllName, EntryPoint = "glMultiTexCoord2iv")]
    public static extern unsafe void MultiTexCoord2(uint target, int* v);
    [DllImport(DllName, EntryPoint = "glMultiTexCoord2s")]
    public static extern unsafe void MultiTexCoord2(uint target, short s, short t);
    [DllImport(DllName, EntryPoint = "glMultiTexCoord2sv")]
    public static extern unsafe void MultiTexCoord2(uint target, short* v);
    [DllImport(DllName, EntryPoint = "glMultiTexCoord3d")]
    public static extern unsafe void MultiTexCoord3(uint target, double s, double t, double r);
    [DllImport(DllName, EntryPoint = "glMultiTexCoord3dv")]
    public static extern unsafe void MultiTexCoord3(uint target, double* v);
    [DllImport(DllName, EntryPoint = "glMultiTexCoord3f")]
    public static extern unsafe void MultiTexCoord3(uint target, float s, float t, float r);
    [DllImport(DllName, EntryPoint = "glMultiTexCoord3fv")]
    public static extern unsafe void MultiTexCoord3(uint target, float* v);
    [DllImport(DllName, EntryPoint = "glMultiTexCoord3i")]
    public static extern unsafe void MultiTexCoord3(uint target, int s, int t, int r);
    [DllImport(DllName, EntryPoint = "glMultiTexCoord3iv")]
    public static extern unsafe void MultiTexCoord3(uint target, int* v);
    [DllImport(DllName, EntryPoint = "glMultiTexCoord3s")]
    public static extern unsafe void MultiTexCoord3(uint target, short s, short t, short r);
    [DllImport(DllName, EntryPoint = "glMultiTexCoord3sv")]
    public static extern unsafe void MultiTexCoord3(uint target, short* v);
    [DllImport(DllName, EntryPoint = "glMultiTexCoord4d")]
    public static extern unsafe void MultiTexCoord4(uint target, double s, double t, double r, double q);
    [DllImport(DllName, EntryPoint = "glMultiTexCoord4dv")]
    public static extern unsafe void MultiTexCoord4(uint target, double* v);
    [DllImport(DllName, EntryPoint = "glMultiTexCoord4f")]
    public static extern unsafe void MultiTexCoord4(uint target, float s, float t, float r, float q);
    [DllImport(DllName, EntryPoint = "glMultiTexCoord4fv")]
    public static extern unsafe void MultiTexCoord4(uint target, float* v);
    [DllImport(DllName, EntryPoint = "glMultiTexCoord4i")]
    public static extern unsafe void MultiTexCoord4(uint target, int s, int t, int r, int q);
    [DllImport(DllName, EntryPoint = "glMultiTexCoord4iv")]
    public static extern unsafe void MultiTexCoord4(uint target, int* v);
    [DllImport(DllName, EntryPoint = "glMultiTexCoord4s")]
    public static extern unsafe void MultiTexCoord4(uint target, short s, short t, short r, short q);
    [DllImport(DllName, EntryPoint = "glMultiTexCoord4sv")]
    public static extern unsafe void MultiTexCoord4(uint target, short* v);
    [DllImport(DllName, EntryPoint = "glNormal3b")]
    public static extern unsafe void Normal3(sbyte nx, sbyte ny, sbyte nz);
    [DllImport(DllName, EntryPoint = "glNormal3bv")]
    public static extern unsafe void Normal3(sbyte* v);
    [DllImport(DllName, EntryPoint = "glNormal3d")]
    public static extern unsafe void Normal3(double nx, double ny, double nz);
    [DllImport(DllName, EntryPoint = "glNormal3dv")]
    public static extern unsafe void Normal3(double* v);
    [DllImport(DllName, EntryPoint = "glNormal3f")]
    public static extern unsafe void Normal3(float nx, float ny, float nz);
    [DllImport(DllName, EntryPoint = "glNormal3fv")]
    public static extern unsafe void Normal3(float* v);
    [DllImport(DllName, EntryPoint = "glNormal3i")]
    public static extern unsafe void Normal3(int nx, int ny, int nz);
    [DllImport(DllName, EntryPoint = "glNormal3iv")]
    public static extern unsafe void Normal3(int* v);
    [DllImport(DllName, EntryPoint = "glNormal3s")]
    public static extern unsafe void Normal3(short nx, short ny, short nz);
    [DllImport(DllName, EntryPoint = "glNormal3sv")]
    public static extern unsafe void Normal3(short* v);
    [DllImport(DllName, EntryPoint = "glFogCoordd")]
    public static extern unsafe void FogCoord(double coord);
    [DllImport(DllName, EntryPoint = "glFogCoorddv")]
    public static extern unsafe void FogCoord(double* coord);
    [DllImport(DllName, EntryPoint = "glFogCoordf")]
    public static extern unsafe void FogCoord(float coord);
    [DllImport(DllName, EntryPoint = "glFogCoordfv")]
    public static extern unsafe void FogCoord(float* coord);
    [DllImport(DllName, EntryPoint = "glColor3b")]
    public static extern unsafe void Color3(sbyte red, sbyte green, sbyte blue);
    [DllImport(DllName, EntryPoint = "glColor3bv")]
    public static extern unsafe void Color3(sbyte* v);
    [DllImport(DllName, EntryPoint = "glColor3d")]
    public static extern unsafe void Color3(double red, double green, double blue);
    [DllImport(DllName, EntryPoint = "glColor3dv")]
    public static extern unsafe void Color3(double* v);
    [DllImport(DllName, EntryPoint = "glColor3f")]
    public static extern unsafe void Color3(float red, float green, float blue);
    [DllImport(DllName, EntryPoint = "glColor3fv")]
    public static extern unsafe void Color3(float* v);
    [DllImport(DllName, EntryPoint = "glColor3i")]
    public static extern unsafe void Color3(int red, int green, int blue);
    [DllImport(DllName, EntryPoint = "glColor3iv")]
    public static extern unsafe void Color3(int* v);
    [DllImport(DllName, EntryPoint = "glColor3s")]
    public static extern unsafe void Color3(short red, short green, short blue);
    [DllImport(DllName, EntryPoint = "glColor3sv")]
    public static extern unsafe void Color3(short* v);
    [DllImport(DllName, EntryPoint = "glColor3ub")]
    public static extern unsafe void Color3(byte red, byte green, byte blue);
    [DllImport(DllName, EntryPoint = "glColor3ubv")]
    public static extern unsafe void Color3(byte* v);
    [DllImport(DllName, EntryPoint = "glColor3ui")]
    public static extern unsafe void Color3(uint red, uint green, uint blue);
    [DllImport(DllName, EntryPoint = "glColor3uiv")]
    public static extern unsafe void Color3(uint* v);
    [DllImport(DllName, EntryPoint = "glColor3us")]
    public static extern unsafe void Color3(ushort red, ushort green, ushort blue);
    [DllImport(DllName, EntryPoint = "glColor3usv")]
    public static extern unsafe void Color3(ushort* v);
    [DllImport(DllName, EntryPoint = "glColor4b")]
    public static extern unsafe void Color4(sbyte red, sbyte green, sbyte blue, sbyte alpha);
    [DllImport(DllName, EntryPoint = "glColor4bv")]
    public static extern unsafe void Color4(sbyte* v);
    [DllImport(DllName, EntryPoint = "glColor4d")]
    public static extern unsafe void Color4(double red, double green, double blue, double alpha);
    [DllImport(DllName, EntryPoint = "glColor4dv")]
    public static extern unsafe void Color4(double* v);
    [DllImport(DllName, EntryPoint = "glColor4f")]
    public static extern unsafe void Color4(float red, float green, float blue, float alpha);
    [DllImport(DllName, EntryPoint = "glColor4fv")]
    public static extern unsafe void Color4(float* v);
    [DllImport(DllName, EntryPoint = "glColor4i")]
    public static extern unsafe void Color4(int red, int green, int blue, int alpha);
    [DllImport(DllName, EntryPoint = "glColor4iv")]
    public static extern unsafe void Color4(int* v);
    [DllImport(DllName, EntryPoint = "glColor4s")]
    public static extern unsafe void Color4(short red, short green, short blue, short alpha);
    [DllImport(DllName, EntryPoint = "glColor4sv")]
    public static extern unsafe void Color4(short* v);
    [DllImport(DllName, EntryPoint = "glColor4ub")]
    public static extern unsafe void Color4(byte red, byte green, byte blue, byte alpha);
    [DllImport(DllName, EntryPoint = "glColor4ubv")]
    public static extern unsafe void Color4(byte* v);
    [DllImport(DllName, EntryPoint = "glColor4ui")]
    public static extern unsafe void Color4(uint red, uint green, uint blue, uint alpha);
    [DllImport(DllName, EntryPoint = "glColor4uiv")]
    public static extern unsafe void Color4(uint* v);
    [DllImport(DllName, EntryPoint = "glColor4us")]
    public static extern unsafe void Color4(ushort red, ushort green, ushort blue, ushort alpha);
    [DllImport(DllName, EntryPoint = "glColor4usv")]
    public static extern unsafe void Color4(ushort* v);
    [DllImport(DllName, EntryPoint = "glSecondaryColor3b")]
    public static extern unsafe void SecondaryColor3(sbyte red, sbyte green, sbyte blue);
    [DllImport(DllName, EntryPoint = "glSecondaryColor3bv")]
    public static extern unsafe void SecondaryColor3(sbyte* v);
    [DllImport(DllName, EntryPoint = "glSecondaryColor3d")]
    public static extern unsafe void SecondaryColor3(double red, double green, double blue);
    [DllImport(DllName, EntryPoint = "glSecondaryColor3dv")]
    public static extern unsafe void SecondaryColor3(double* v);
    [DllImport(DllName, EntryPoint = "glSecondaryColor3f")]
    public static extern unsafe void SecondaryColor3(float red, float green, float blue);
    [DllImport(DllName, EntryPoint = "glSecondaryColor3fv")]
    public static extern unsafe void SecondaryColor3(float* v);
    [DllImport(DllName, EntryPoint = "glSecondaryColor3i")]
    public static extern unsafe void SecondaryColor3(int red, int green, int blue);
    [DllImport(DllName, EntryPoint = "glSecondaryColor3iv")]
    public static extern unsafe void SecondaryColor3(int* v);
    [DllImport(DllName, EntryPoint = "glSecondaryColor3s")]
    public static extern unsafe void SecondaryColor3(short red, short green, short blue);
    [DllImport(DllName, EntryPoint = "glSecondaryColor3sv")]
    public static extern unsafe void SecondaryColor3(short* v);
    [DllImport(DllName, EntryPoint = "glSecondaryColor3ub")]
    public static extern unsafe void SecondaryColor3(byte red, byte green, byte blue);
    [DllImport(DllName, EntryPoint = "glSecondaryColor3ubv")]
    public static extern unsafe void SecondaryColor3(byte* v);
    [DllImport(DllName, EntryPoint = "glSecondaryColor3ui")]
    public static extern unsafe void SecondaryColor3(uint red, uint green, uint blue);
    [DllImport(DllName, EntryPoint = "glSecondaryColor3uiv")]
    public static extern unsafe void SecondaryColor3(uint* v);
    [DllImport(DllName, EntryPoint = "glSecondaryColor3us")]
    public static extern unsafe void SecondaryColor3(ushort red, ushort green, ushort blue);
    [DllImport(DllName, EntryPoint = "glSecondaryColor3usv")]
    public static extern unsafe void SecondaryColor3(ushort* v);
    [DllImport(DllName, EntryPoint = "glIndexd")]
    public static extern unsafe void Index(double c);
    [DllImport(DllName, EntryPoint = "glIndexdv")]
    public static extern unsafe void Index(double* c);
    [DllImport(DllName, EntryPoint = "glIndexf")]
    public static extern unsafe void Index(float c);
    [DllImport(DllName, EntryPoint = "glIndexfv")]
    public static extern unsafe void Index(float* c);
    [DllImport(DllName, EntryPoint = "glIndexi")]
    public static extern unsafe void Index(int c);
    [DllImport(DllName, EntryPoint = "glIndexiv")]
    public static extern unsafe void Index(int* c);
    [DllImport(DllName, EntryPoint = "glIndexs")]
    public static extern unsafe void Index(short c);
    [DllImport(DllName, EntryPoint = "glIndexsv")]
    public static extern unsafe void Index(short* c);
    [DllImport(DllName, EntryPoint = "glVertexAttrib1d")]
    public static extern unsafe void VertexAttrib1(uint index, double x);
    [DllImport(DllName, EntryPoint = "glVertexAttrib1dv")]
    public static extern unsafe void VertexAttrib1(uint index, double* v);
    [DllImport(DllName, EntryPoint = "glVertexAttrib1f")]
    public static extern unsafe void VertexAttrib1(uint index, float x);
    [DllImport(DllName, EntryPoint = "glVertexAttrib1fv")]
    public static extern unsafe void VertexAttrib1(uint index, float* v);
    [DllImport(DllName, EntryPoint = "glVertexAttrib1s")]
    public static extern unsafe void VertexAttrib1(uint index, short x);
    [DllImport(DllName, EntryPoint = "glVertexAttrib1sv")]
    public static extern unsafe void VertexAttrib1(uint index, short* v);
    [DllImport(DllName, EntryPoint = "glVertexAttrib2d")]
    public static extern unsafe void VertexAttrib2(uint index, double x, double y);
    [DllImport(DllName, EntryPoint = "glVertexAttrib2dv")]
    public static extern unsafe void VertexAttrib2(uint index, double* v);
    [DllImport(DllName, EntryPoint = "glVertexAttrib2f")]
    public static extern unsafe void VertexAttrib2(uint index, float x, float y);
    [DllImport(DllName, EntryPoint = "glVertexAttrib2fv")]
    public static extern unsafe void VertexAttrib2(uint index, float* v);
    [DllImport(DllName, EntryPoint = "glVertexAttrib2s")]
    public static extern unsafe void VertexAttrib2(uint index, short x, short y);
    [DllImport(DllName, EntryPoint = "glVertexAttrib2sv")]
    public static extern unsafe void VertexAttrib2(uint index, short* v);
    [DllImport(DllName, EntryPoint = "glVertexAttrib3d")]
    public static extern unsafe void VertexAttrib3(uint index, double x, double y, double z);
    [DllImport(DllName, EntryPoint = "glVertexAttrib3dv")]
    public static extern unsafe void VertexAttrib3(uint index, double* v);
    [DllImport(DllName, EntryPoint = "glVertexAttrib3f")]
    public static extern unsafe void VertexAttrib3(uint index, float x, float y, float z);
    [DllImport(DllName, EntryPoint = "glVertexAttrib3fv")]
    public static extern unsafe void VertexAttrib3(uint index, float* v);
    [DllImport(DllName, EntryPoint = "glVertexAttrib3s")]
    public static extern unsafe void VertexAttrib3(uint index, short x, short y, short z);
    [DllImport(DllName, EntryPoint = "glVertexAttrib3sv")]
    public static extern unsafe void VertexAttrib3(uint index, short* v);
    [DllImport(DllName, EntryPoint = "glVertexAttrib4d")]
    public static extern unsafe void VertexAttrib4(uint index, double x, double y, double z, double w);
    [DllImport(DllName, EntryPoint = "glVertexAttrib4dv")]
    public static extern unsafe void VertexAttrib4(uint index, double* v);
    [DllImport(DllName, EntryPoint = "glVertexAttrib4f")]
    public static extern unsafe void VertexAttrib4(uint index, float x, float y, float z, float w);
    [DllImport(DllName, EntryPoint = "glVertexAttrib4fv")]
    public static extern unsafe void VertexAttrib4(uint index, float* v);
    [DllImport(DllName, EntryPoint = "glVertexAttrib4s")]
    public static extern unsafe void VertexAttrib4(uint index, short x, short y, short z, short w);
    [DllImport(DllName, EntryPoint = "glVertexAttrib4sv")]
    public static extern unsafe void VertexAttrib4(uint index, short* v);
}