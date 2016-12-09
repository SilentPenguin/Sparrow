using System.Runtime.InteropServices;

public static partial class Gl
{
    [DllImport(DllName)]
    public static extern unsafe GLvoid Flush();
    [DllImport(DllName)]
    public static extern unsafe GLvoid Finish();
    [DllImport(DllName)]
    public static extern unsafe GLvoid FenceSync(GLenum condition, GLbitfield flags);
    [DllImport(DllName)]
    public static extern unsafe GLvoid DeleteSync(GLsync sync);
    [DllImport(DllName)]
    public static extern unsafe GLvoid ClientWaitSync(GLsync sync, GLbitfield flags, GLuint64 timeout);
    [DllImport(DllName)]
    public static extern unsafe GLvoid WaitSync(GLsync sync, GLbitfield flags, GLuint64 timeout);
    [DllImport(DllName)]
    public static extern unsafe GLvoid GetSync(GLsync sync, GLenum pname, GLsizei bufSize, GLsizei* length, GLint* values);
    [DllImport(DllName)]
    public static extern unsafe GLvoid IsSync(GLsync sync);
}