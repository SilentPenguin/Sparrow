using System.Runtime.InteropServices;

public static partial class Gl
{
    [DllImport(DllName, EntryPoint = "glActiveTexture")]
    public static extern unsafe void ActiveTexture(uint texture);
    [DllImport(DllName, EntryPoint = "glTexImage1D")]
    public static extern unsafe void TexImage1D(uint target, int level, int internalformat, int width, int border, uint format, uint type, void* pixels);
    [DllImport(DllName, EntryPoint = "glTexImage2D")]
    public static extern unsafe void TexImage2D(uint target, int level, int internalformat, int width, int height, int border, uint format, uint type, void* pixels);
    [DllImport(DllName, EntryPoint = "glTexImage3D")]
    public static extern unsafe void TexImage3D(uint target, int level, int internalformat, int width, int height, int depth, int border, uint format, uint type, void* pixels);
    [DllImport(DllName, EntryPoint = "glCopyTexImage1D")]
    public static extern unsafe void CopyTexImage1D(uint target, int level, uint internalformat, int x, int y, int width, int border);
    [DllImport(DllName, EntryPoint = "glCopyTexImage2D")]
    public static extern unsafe void CopyTexImage2D(uint target, int level, uint internalformat, int x, int y, int width, int height, int border);
    [DllImport(DllName, EntryPoint = "glTexSubImage1D")]
    public static extern unsafe void TexSubImage1D(uint target, int level, int xoffset, int width, uint format, uint type, void* pixels);
    [DllImport(DllName, EntryPoint = "glTexSubImage2D")]
    public static extern unsafe void TexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, void* pixels);
    [DllImport(DllName, EntryPoint = "glTexSubImage3D")]
    public static extern unsafe void TexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, void* pixels);
    [DllImport(DllName, EntryPoint = "glCopyTexSubImage1D")]
    public static extern unsafe void CopyTexSubImage1D(uint target, int level, int xoffset, int x, int y, int width);
    [DllImport(DllName, EntryPoint = "glCopyTexSubImage2D")]
    public static extern unsafe void CopyTexSubImage2D(uint target, int level, int xoffset, int yoffset, int x, int y, int width, int height);
    [DllImport(DllName, EntryPoint = "glCopyTexSubImage3D")]
    public static extern unsafe void CopyTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height);
    [DllImport(DllName, EntryPoint = "glCompressedTexImage1D")]
    public static extern unsafe void CompressedTexImage1D(uint target, int level, uint internalformat, int width, int border, int imageSize, void* data);
    [DllImport(DllName, EntryPoint = "glCompressedTexImage2D")]
    public static extern unsafe void CompressedTexImage2D(uint target, int level, uint internalformat, int width, int height, int border, int imageSize, void* data);
    [DllImport(DllName, EntryPoint = "glCompressedTexImage3D")]
    public static extern unsafe void CompressedTexImage3D(uint target, int level, uint internalformat, int width, int height, int depth, int border, int imageSize, void* data);
    [DllImport(DllName, EntryPoint = "glCompressedTexSubImage1D")]
    public static extern unsafe void CompressedTexSubImage1D(uint target, int level, int xoffset, int width, uint format, int imageSize, void* data);
    [DllImport(DllName, EntryPoint = "glCompressedTexSubImage2D")]
    public static extern unsafe void CompressedTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, void* data);
    [DllImport(DllName, EntryPoint = "glCompressedTexSubImage3D")]
    public static extern unsafe void CompressedTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, void* data);
    [DllImport(DllName, EntryPoint = "glTexImage2DMultisample")]
    public static extern unsafe void TexImage2DMultisample(uint target, int samples, uint internalformat, int width, int height, bool fixedsamplelocations);
    [DllImport(DllName, EntryPoint = "glTexImage3DMultisample")]
    public static extern unsafe void TexImage3DMultisample(uint target, int samples, uint internalformat, int width, int height, int depth, bool fixedsamplelocations);
    [DllImport(DllName, EntryPoint = "glTexBuffer")]
    public static extern unsafe void TexBuffer(uint target, uint internalformat, uint buffer);
    [DllImport(DllName, EntryPoint = "glTexParameterf")]
    public static extern unsafe void TexParameter(uint target, uint pname, float param);
    [DllImport(DllName, EntryPoint = "glTexParameterfv")]
    public static extern unsafe void TexParameter(uint target, uint pname, float* @params);
    [DllImport(DllName, EntryPoint = "glTexParameteri")]
    public static extern unsafe void TexParameter(uint target, uint pname, int param);
    [DllImport(DllName, EntryPoint = "glTexParameteriv")]
    public static extern unsafe void TexParameter(uint target, uint pname, int* @params);
    [DllImport(DllName, EntryPoint = "glTexParameterIiv")]
    public static extern unsafe void TexParameterI(uint target, uint pname, int* @params);
    [DllImport(DllName, EntryPoint = "glTexParameterIuiv")]
    public static extern unsafe void TexParameterI(uint target, uint pname, uint* @params);
    [DllImport(DllName, EntryPoint = "glGenerateMipmap")]
    public static extern unsafe void GenerateMipmap(uint target);
    [DllImport(DllName, EntryPoint = "glBindTexture")]
    public static extern unsafe void BindTexture(uint target, uint texture);
    [DllImport(DllName, EntryPoint = "glGenTextures")]
    public static extern unsafe void GenTextures(int n, uint* textures);
    [DllImport(DllName, EntryPoint = "glAreTexturesResident")]
    public static extern unsafe void AreTexturesResident(int n, uint* textures, bool* residences);
    [DllImport(DllName, EntryPoint = "glPrioritizeTextures")]
    public static extern unsafe void PrioritizeTextures(int n, uint* textures, float* priorities);
    [DllImport(DllName, EntryPoint = "glTexEnvf")]
    public static extern unsafe void TexEnv(uint target, uint pname, float param);
    [DllImport(DllName, EntryPoint = "glTexEnvfv")]
    public static extern unsafe void TexEnv(uint target, uint pname, float* @params);
    [DllImport(DllName, EntryPoint = "glTexEnvi")]
    public static extern unsafe void TexEnv(uint target, uint pname, int param);
    [DllImport(DllName, EntryPoint = "glTexEnviv")]
    public static extern unsafe void TexEnv(uint target, uint pname, int* @params);
    [DllImport(DllName, EntryPoint = "glGetTexEnvfv")]
    public static extern unsafe void GetTexEnv(uint target, uint pname, float* @params);
    [DllImport(DllName, EntryPoint = "glGetTexEnviv")]
    public static extern unsafe void GetTexEnv(uint target, uint pname, int* @params);
    [DllImport(DllName, EntryPoint = "glGetTexGendv")]
    public static extern unsafe void GetTexGen(uint coord, uint pname, double* @params);
    [DllImport(DllName, EntryPoint = "glGetTexGenfv")]
    public static extern unsafe void GetTexGen(uint coord, uint pname, float* @params);
    [DllImport(DllName, EntryPoint = "glGetTexGeniv")]
    public static extern unsafe void GetTexGen(uint coord, uint pname, int* @params);
    [DllImport(DllName, EntryPoint = "glGetTexParameterfv")]
    public static extern unsafe void GetTexParameter(uint target, uint pname, float* @params);
    [DllImport(DllName, EntryPoint = "glGetTexParameteriv")]
    public static extern unsafe void GetTexParameter(uint target, uint pname, int* @params);
    [DllImport(DllName, EntryPoint = "glGetTexParameterIiv")]
    public static extern unsafe void GetTexParameterI(uint target, uint pname, int* @params);
    [DllImport(DllName, EntryPoint = "glGetTexParameterIuiv")]
    public static extern unsafe void GetTexParameterI(uint target, uint pname, uint* @params);
    [DllImport(DllName, EntryPoint = "glGetTexLevelParameterfv")]
    public static extern unsafe void GetTexLevelParameter(uint target, int level, uint pname, float* @params);
    [DllImport(DllName, EntryPoint = "glGetTexLevelParameteriv")]
    public static extern unsafe void GetTexLevelParameter(uint target, int level, uint pname, int* @params);
    [DllImport(DllName, EntryPoint = "glGetTexImage")]
    public static extern unsafe void GetTexImage(uint target, int level, uint format, uint type, void* pixels);
    [DllImport(DllName, EntryPoint = "glGetCompressedTexImage")]
    public static extern unsafe void GetCompressedTexImage(uint target, int level, void* img);
    [DllImport(DllName, EntryPoint = "glIsTexture")]
    public static extern unsafe void IsTexture(uint texture);
}