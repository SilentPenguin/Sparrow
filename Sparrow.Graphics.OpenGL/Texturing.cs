using System.Runtime.InteropServices;

public static partial class Gl
{
    [DllImport(DllName)]
    public static extern unsafe GLvoid ActiveTexture(GLenum texture);
    [DllImport(DllName)]
    public static extern unsafe GLvoid TexImage1D(GLenum target, GLint level, GLint internalformat, GLsizei width, GLint border, GLenum format, GLenum type, GLvoid* pixels);
    [DllImport(DllName)]
    public static extern unsafe GLvoid TexImage2D(GLenum target, GLint level, GLint internalformat, GLsizei width, GLsizei height, GLint border, GLenum format, GLenum type, GLvoid* pixels);
    [DllImport(DllName)]
    public static extern unsafe GLvoid TexImage3D(GLenum target, GLint level, GLint internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLenum format, GLenum type, GLvoid* pixels);
    [DllImport(DllName)]
    public static extern unsafe GLvoid CopyTexImage1D(GLenum target, GLint level, GLenum internalformat, GLint x, GLint y, GLsizei width, GLint border);
    [DllImport(DllName)]
    public static extern unsafe GLvoid CopyTexImage2D(GLenum target, GLint level, GLenum internalformat, GLint x, GLint y, GLsizei width, GLsizei height, GLint border);
    [DllImport(DllName)]
    public static extern unsafe GLvoid TexSubImage1D(GLenum target, GLint level, GLint xoffset, GLsizei width, GLenum format, GLenum type, GLvoid* pixels);
    [DllImport(DllName)]
    public static extern unsafe GLvoid TexSubImage2D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLenum type, GLvoid* pixels);
    [DllImport(DllName)]
    public static extern unsafe GLvoid TexSubImage3D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLenum type, GLvoid* pixels);
    [DllImport(DllName)]
    public static extern unsafe GLvoid CopyTexSubImage1D(GLenum target, GLint level, GLint xoffset, GLint x, GLint y, GLsizei width);
    [DllImport(DllName)]
    public static extern unsafe GLvoid CopyTexSubImage2D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint x, GLint y, GLsizei width, GLsizei height);
    [DllImport(DllName)]
    public static extern unsafe GLvoid CopyTexSubImage3D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLint x, GLint y, GLsizei width, GLsizei height);
    [DllImport(DllName)]
    public static extern unsafe GLvoid CompressedTexImage1D(GLenum target, GLint level, GLenum internalformat, GLsizei width, GLint border, GLsizei imageSize, GLvoid* data);
    [DllImport(DllName)]
    public static extern unsafe GLvoid CompressedTexImage2D(GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLint border, GLsizei imageSize, GLvoid* data);
    [DllImport(DllName)]
    public static extern unsafe GLvoid CompressedTexImage3D(GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLsizei imageSize, GLvoid* data);
    [DllImport(DllName)]
    public static extern unsafe GLvoid CompressedTexSubImage1D(GLenum target, GLint level, GLint xoffset, GLsizei width, GLenum format, GLsizei imageSize, GLvoid* data);
    [DllImport(DllName)]
    public static extern unsafe GLvoid CompressedTexSubImage2D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLsizei imageSize, GLvoid* data);
    [DllImport(DllName)]
    public static extern unsafe GLvoid CompressedTexSubImage3D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLsizei imageSize, GLvoid* data);
    [DllImport(DllName)]
    public static extern unsafe GLvoid TexImage2DMultisample(GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height, GLboolean fixedsamplelocations);
    [DllImport(DllName)]
    public static extern unsafe GLvoid TexImage3DMultisample(GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLboolean fixedsamplelocations);
    [DllImport(DllName)]
    public static extern unsafe GLvoid TexBuffer(GLenum target, GLenum internalformat, GLuint buffer);
    [DllImport(DllName)]
    public static extern unsafe GLvoid TexParameter(GLenum target, GLenum pname, GLfloat param);
    [DllImport(DllName)]
    public static extern unsafe GLvoid TexParameter(GLenum target, GLenum pname, GLfloat* @params);
    [DllImport(DllName)]
    public static extern unsafe GLvoid TexParameter(GLenum target, GLenum pname, GLint param);
    [DllImport(DllName)]
    public static extern unsafe GLvoid TexParameter(GLenum target, GLenum pname, GLint* @params);
    [DllImport(DllName)]
    public static extern unsafe GLvoid TexParameterI(GLenum target, GLenum pname, GLint* @params);
    [DllImport(DllName)]
    public static extern unsafe GLvoid TexParameterI(GLenum target, GLenum pname, GLuint* @params);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GenerateMipmap(GLenum target);
    [DllImport(DllName)]
    public static extern unsafe GLvoid BindTexture(GLenum target, GLuint texture);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GenTextures(GLsizei n, GLuint* textures);
    [DllImport(DllName)]
    public static extern unsafe GLvoid AreTexturesResident(GLsizei n, GLuint* textures, GLboolean* residences);
    [DllImport(DllName)]
    public static extern unsafe GLvoid PrioritizeTextures(GLsizei n, GLuint* textures, GLfloat* priorities);
    [DllImport(DllName)]
    public static extern unsafe GLvoid TexEnv(GLenum target, GLenum pname, GLfloat param);
    [DllImport(DllName)]
    public static extern unsafe GLvoid TexEnv(GLenum target, GLenum pname, GLfloat* @params);
    [DllImport(DllName)]
    public static extern unsafe GLvoid TexEnv(GLenum target, GLenum pname, GLint param);
    [DllImport(DllName)]
    public static extern unsafe GLvoid TexEnv(GLenum target, GLenum pname, GLint* @params);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GetTexEnv(GLenum target, GLenum pname, GLfloat* @params);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GetTexEnv(GLenum target, GLenum pname, GLint* @params);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GetTexGen(GLenum coord, GLenum pname, GLdouble* @params);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GetTexGen(GLenum coord, GLenum pname, GLfloat* @params);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GetTexGen(GLenum coord, GLenum pname, GLint* @params);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GetTexParameter(GLenum target, GLenum pname, GLfloat* @params);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GetTexParameter(GLenum target, GLenum pname, GLint* @params);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GetTexParameterI(GLenum target, GLenum pname, GLint* @params);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GetTexParameterI(GLenum target, GLenum pname, GLuint* @params);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GetTexLevelParameter(GLenum target, GLint level, GLenum pname, GLfloat* @params);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GetTexLevelParameter(GLenum target, GLint level, GLenum pname, GLint* @params);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GetTexImage(GLenum target, GLint level, GLenum format, GLenum type, GLvoid* pixels);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GetCompressedTexImage(GLenum target, GLint level, GLvoid* img);
    [DllImport(DllName)]
    public static extern unsafe GLvoid IsTexture(GLuint texture);
}