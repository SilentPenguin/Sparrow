using System.Runtime.InteropServices;

public static partial class Gl
{
    [DllImport(DllName, EntryPoint = "glBindFramebuffer")]
    public static extern unsafe void BindFramebuffer(uint target, uint framebuffer);
    [DllImport(DllName, EntryPoint = "glDeleteFramebuffers")]
    public static extern unsafe void DeleteFramebuffers(int n, uint* framebuffers);
    [DllImport(DllName, EntryPoint = "glGenFramebuffers")]
    public static extern unsafe void GenFramebuffers(int n, uint* framebuffers);
    [DllImport(DllName, EntryPoint = "glBindRenderbuffer")]
    public static extern unsafe void BindRenderbuffer(uint target, uint renderbuffer);
    [DllImport(DllName, EntryPoint = "glDeleteRenderbuffers")]
    public static extern unsafe void DeleteRenderbuffers(int n, uint* renderbuffers);
    [DllImport(DllName, EntryPoint = "glGenRenderbuffers")]
    public static extern unsafe void GenRenderbuffers(int n, uint* renderbuffers);
    [DllImport(DllName, EntryPoint = "glRenderbufferStorage")]
    public static extern unsafe void RenderbufferStorage(uint target, uint internalformat, int width, int height);
    [DllImport(DllName, EntryPoint = "glRenderbufferStorageMultisample")]
    public static extern unsafe void RenderbufferStorageMultisample(uint target, int samples, uint internalformat, int width, int height);
    [DllImport(DllName, EntryPoint = "glFramebufferRenderbuffer")]
    public static extern unsafe void FramebufferRenderbuffer(uint target, uint attachment, uint renderbuffertarget, uint renderbuffer);
    [DllImport(DllName, EntryPoint = "glFramebufferTexture")]
    public static extern unsafe void FramebufferTexture(uint target, uint attachment, uint texture, int level);
    [DllImport(DllName, EntryPoint = "glFramebufferTexture1D")]
    public static extern unsafe void FramebufferTexture1D(uint target, uint attachment, uint textarget, uint texture, int level);
    [DllImport(DllName, EntryPoint = "glFramebufferTexture2D")]
    public static extern unsafe void FramebufferTexture2D(uint target, uint attachment, uint textarget, uint texture, int level);
    [DllImport(DllName, EntryPoint = "glFramebufferTexture3D")]
    public static extern unsafe void FramebufferTexture3D(uint target, uint attachment, uint textarget, uint texture, int level, int zoffset);
    [DllImport(DllName, EntryPoint = "glFramebufferTextureLayer")]
    public static extern unsafe void FramebufferTextureLayer(uint target, uint attachment, uint texture, int level, int layer);
    [DllImport(DllName, EntryPoint = "glCheckFramebufferStatus")]
    public static extern unsafe void CheckFramebufferStatus(uint target);
    [DllImport(DllName, EntryPoint = "glIsFramebuffer")]
    public static extern unsafe void IsFramebuffer(uint framebuffer);
    [DllImport(DllName, EntryPoint = "glGetFramebufferAttachmentParameteriv")]
    public static extern unsafe void GetFramebufferAttachmentParameter(uint target, uint attachment, uint pname, int* @params);
    [DllImport(DllName, EntryPoint = "glIsRenderbuffer")]
    public static extern unsafe void IsRenderbuffer(uint renderbuffer);
    [DllImport(DllName, EntryPoint = "glGetRenderbufferParameteriv")]
    public static extern unsafe void GetRenderbufferParameter(uint target, uint pname, int* @params);
}