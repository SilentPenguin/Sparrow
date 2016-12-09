using System.Runtime.InteropServices;

public static partial class Gl
{
    [DllImport(DllName)]
    public static extern unsafe GLvoid BindFramebuffer(GLenum target, GLuint framebuffer);
    [DllImport(DllName)]
    public static extern unsafe GLvoid DeleteFramebuffers(GLsizei n, GLuint* framebuffers);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GenFramebuffers(GLsizei n, GLuint* framebuffers);
    [DllImport(DllName)]
    public static extern unsafe GLvoid BindRenderbuffer(GLenum target, GLuint renderbuffer);
    [DllImport(DllName)]
    public static extern unsafe GLvoid DeleteRenderbuffers(GLsizei n, GLuint* renderbuffers);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GenRenderbuffers(GLsizei n, GLuint* renderbuffers);
    [DllImport(DllName)]
    public static extern unsafe GLvoid RenderbufferStorage(GLenum target, GLenum internalformat, GLsizei width, GLsizei height);
    [DllImport(DllName)]
    public static extern unsafe GLvoid RenderbufferStorageMultisample(GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height);
    [DllImport(DllName)]
    public static extern unsafe GLvoid FramebufferRenderbuffer(GLenum target, GLenum attachment, GLenum renderbuffertarget, GLuint renderbuffer);
    [DllImport(DllName)]
    public static extern unsafe GLvoid FramebufferTexture(GLenum target, GLenum attachment, GLuint texture, GLint level);
    [DllImport(DllName)]
    public static extern unsafe GLvoid FramebufferTexture1D(GLenum target, GLenum attachment, GLenum textarget, GLuint texture, GLint level);
    [DllImport(DllName)]
    public static extern unsafe GLvoid FramebufferTexture2D(GLenum target, GLenum attachment, GLenum textarget, GLuint texture, GLint level);
    [DllImport(DllName)]
    public static extern unsafe GLvoid FramebufferTexture3D(GLenum target, GLenum attachment, GLenum textarget, GLuint texture, GLint level, GLint zoffset);
    [DllImport(DllName)]
    public static extern unsafe GLvoid FramebufferTextureLayer(GLenum target, GLenum attachment, GLuint texture, GLint level, GLint layer);
    [DllImport(DllName)]
    public static extern unsafe GLvoid CheckFramebufferStatus(GLenum target);
    [DllImport(DllName)]
    public static extern unsafe GLvoid IsFramebuffer(GLuint framebuffer);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GetFramebufferAttachmentParameter(GLenum target, GLenum attachment, GLenum pname, GLint* @params);
    [DllImport(DllName)]
    public static extern unsafe GLvoid IsRenderbuffer(GLuint renderbuffer);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GetRenderbufferParameter(GLenum target, GLenum pname, GLint* @params);
}