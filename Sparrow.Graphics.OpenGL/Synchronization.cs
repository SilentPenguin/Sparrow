using System.Runtime.InteropServices;

public static partial class Gl
{
    [DllImport(DllName, EntryPoint = "glFlush")]
    public static extern unsafe GLvoid Flush();
    [DllImport(DllName, EntryPoint = "glFinish")]
    public static extern unsafe GLvoid Finish();
    [DllImport(DllName, EntryPoint = "glFenceSync")]
    public static extern unsafe GLvoid FenceSync(GLenum condition, GLbitfield flags);
    [DllImport(DllName, EntryPoint = "glDeleteSync")]
    public static extern unsafe GLvoid DeleteSync(GLsync sync);
    [DllImport(DllName, EntryPoint = "glClientWaitSync")]
    public static extern unsafe GLvoid ClientWaitSync(GLsync sync, GLbitfield flags, GLuint64 timeout);
    [DllImport(DllName, EntryPoint = "glWaitSync")]
    public static extern unsafe GLvoid WaitSync(GLsync sync, GLbitfield flags, GLuint64 timeout);
    [DllImport(DllName, EntryPoint = "glGetSynciv")]
    public static extern unsafe GLvoid GetSync(GLsync sync, GLenum pname, GLsizei bufSize, GLsizei* length, GLint* values);
    [DllImport(DllName, EntryPoint = "glIsSync")]
    public static extern unsafe GLvoid IsSync(GLsync sync);
}