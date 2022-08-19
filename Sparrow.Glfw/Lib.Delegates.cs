using System.Runtime.InteropServices;

namespace Sparrow.Glfw;

public partial class Lib
{
    public delegate void GLFWerrorfun(int code, [MarshalAs(UnmanagedType.LPUTF8Str)] string description);
    public delegate void GLFWmonitorfun(GLFWmonitor monitor, int @event);
    public delegate void GLFWwindowposfun(GLFWwindow window, int xpos, int ypos);
    public delegate void GLFWwindowsizefun(GLFWwindow window, int width, int height);
    public delegate void GLFWwindowclosefun(GLFWwindow window);
    public delegate void GLFWwindowrefreshfun(GLFWwindow window);
    public delegate void GLFWwindowfocusfun(GLFWwindow window, int focused);
    public delegate void GLFWwindowiconifyfun(GLFWwindow window, int iconified);
    public delegate void GLFWwindowmaximizefun(GLFWwindow window, int maximized);
    public delegate void GLFWframebuffersizefun(GLFWwindow window, int width, int height);
    public delegate void GLFWwindowcontentsscalefun(GLFWwindow window, float xscale, float yscale);
    public delegate void GLFWkeyfun(GLFWwindow window, int key, int scancode, int action, int mods);
    public delegate void GLFWcharfun(GLFWwindow window, uint codepoint);
    public delegate void GLFWcharmodsfun(GLFWwindow window, uint codepoint, int mods);
    public delegate void GLFWmousebuttonfun(GLFWwindow window, int button, int action, int mods);
    public delegate void GLFWcursorposfun(GLFWwindow window, double xpos, double ypos);
    public delegate void GLFWcursorenterfun(GLFWwindow window, int entered);
    public delegate void GLFWscrollfun(GLFWwindow window, double xoffset, double yoffset);
    public delegate void GLFWdropfun(GLFWwindow window, int pathCount, [MarshalAs(UnmanagedType.LPUTF8Str, SizeParamIndex = 1)] string[] paths);
    public delegate void GLFWjoystickfun(int jid, int @event);
}
