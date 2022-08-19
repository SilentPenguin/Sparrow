using System.Runtime.InteropServices;

namespace Sparrow.Glfw;

public partial class Lib
{
    [LibraryImport(LIB)]
    public static partial int glfwInit();
    [LibraryImport(LIB)]
    public static partial void glfwTerminate();
    [LibraryImport(LIB)]
    public static partial void glfwInitHint(int hint, int value);
    [LibraryImport(LIB)]
    public static partial void glfwGetVersion(out int major, out int minor, out int revision);
    [LibraryImport(LIB)]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static partial string glfwGetVersionString();
    [LibraryImport(LIB)]
    public static partial int glfwGetError([MarshalAs(UnmanagedType.LPUTF8Str)] out string description);
    [LibraryImport(LIB)]
    public static partial GLFWerrorfun SetErrorCallback(GLFWerrorfun callback);
    [LibraryImport(LIB)]
    [return: MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)]
    public static partial GLFWmonitor[] glfwGetMonitors(out int count);
    [LibraryImport(LIB)]
    public static partial GLFWmonitor glfwGetPrimaryMonitor();
    [LibraryImport(LIB)]
    public static partial void glfwGetMonitorPos(GLFWmonitor monitor, out int xpos, out int ypos);
    [LibraryImport(LIB)]
    public static partial void glfwGetMonitorWorkarea(GLFWmonitor monitor, out int xpos, out int ypos, out int width, out int height);
    [LibraryImport(LIB)]
    public static partial void glfwGetMonitorPhysicalSize(GLFWmonitor monitor, out int widthMM, out int heightMM);
    [LibraryImport(LIB)]
    public static partial void glfwGetMonitorContentScale(GLFWmonitor monitor, out float xscale, out float yscale);
    [LibraryImport(LIB)]
    [return: MarshalAs(UnmanagedType.LPUTF8Str)]
    public static partial string glfwGetMonitorName(GLFWmonitor monitor);
    [LibraryImport(LIB)]
    public static partial void glfwSetMonitorUserPointer(GLFWmonitor monitor, nint pointer);
    [LibraryImport(LIB)]
    public static partial nint glfwGetMonitorUserPointer(GLFWmonitor monitor);
    [LibraryImport(LIB)]
    public static partial GLFWmonitorfun SetMonitorCallback(GLFWmonitorfun callback);
    [LibraryImport(LIB)]
    [return: MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)]
    public static partial GLFWvidmode[] glfwGetVideoModes(GLFWmonitor monitor, out int count);
    [LibraryImport(LIB)]
    public static partial GLFWvidmode glfwGetVideoMode(GLFWmonitor monitor);
    [LibraryImport(LIB)]
    public static partial void glfwSetGamma(GLFWmonitor monitor, float gamma);
    [LibraryImport(LIB)]
    public static partial GLFWgammaramp glfwGetGammaRamp(GLFWmonitor monitor);
    [LibraryImport(LIB)]
    public static partial void glfwSetGammaRamp(GLFWmonitor monitor, GLFWgammaramp ramp);
    [LibraryImport(LIB)]
    public static partial void glfwDefaultWindowHints();
    [LibraryImport(LIB)]
    public static partial void glfwWindowHint(int hint, int value);
    [LibraryImport(LIB)]
    public static partial void glfwWindowHintString(int hint, [MarshalAs(UnmanagedType.LPUTF8Str)] string value);
    [LibraryImport(LIB)]
    public static partial GLFWwindow glfwCreateWindow(int width, int height, [MarshalAs(UnmanagedType.LPUTF8Str)] string title, GLFWmonitor monitor, GLFWwindow share);
    [LibraryImport(LIB)]
    public static partial void glfwDestroyWindow(GLFWwindow window);
    [LibraryImport(LIB)]
    public static partial int glfwWindowShouldClose(GLFWwindow window);
    [LibraryImport(LIB)]
    public static partial void glfwSetWindowShouldClose(GLFWwindow window, int value);
    [LibraryImport(LIB)]
    public static partial void glfwSetWindowTitle(GLFWwindow window, [MarshalAs(UnmanagedType.LPUTF8Str)] string title);
    [LibraryImport(LIB)]
    public static partial void glfwSetWindowIcon(GLFWwindow window, int count, GLFWimage[] images);
    [LibraryImport(LIB)]
    public static partial void glfwGetWindowPos(GLFWwindow window, out int xpos, out int ypos);
    [LibraryImport(LIB)]
    public static partial void glfwSetWindowPos(GLFWwindow window, int xpos, int ypos);
    [LibraryImport(LIB)]
    public static partial void glfwGetWindowSize(GLFWwindow window, out int width, out int height);
    [LibraryImport(LIB)]
    public static partial void glfwSetWindowSizeLimits(GLFWwindow window, int minwidth, int minheight, int maxwidth, int maxheight);
    [LibraryImport(LIB)]
    public static partial void glfwSetWindowAspectRatio(GLFWwindow window, int numer, int denom);
    [LibraryImport(LIB)]
    public static partial void glfwSetWindowSize(GLFWwindow window, int width, int height);
    [LibraryImport(LIB)]
    public static partial void glfwGetFramebufferSize(GLFWwindow window, out int width, out int height);
    [LibraryImport(LIB)]
    public static partial void glfwGetWindowFrameSize(GLFWwindow window, out int left, out int top, out int right, out int bottom);
    [LibraryImport(LIB)]
    public static partial void glfwGetWindowContentScale(GLFWwindow window, out float xscale, out float yscale);
    [LibraryImport(LIB)]
    public static partial float glfwGetWindowOpacity(GLFWwindow window);
    [LibraryImport(LIB)]
    public static partial void glfwSetWindowOpacity(GLFWwindow window, float opacity);
    [LibraryImport(LIB)]
    public static partial void glfwIconifyWindow(GLFWwindow window);
    [LibraryImport(LIB)]
    public static partial void glfwRestoreWindow(GLFWwindow window);
    [LibraryImport(LIB)]
    public static partial void glfwMaximizeWindow(GLFWwindow window);
    [LibraryImport(LIB)]
    public static partial void glfwShowWindow(GLFWwindow window);
    [LibraryImport(LIB)]
    public static partial void glfwHideWindow(GLFWwindow window);
    [LibraryImport(LIB)]
    public static partial void glfwFocusWindow(GLFWwindow window);
    [LibraryImport(LIB)]
    public static partial void glfwRequestWindowAttention(GLFWwindow window);
    [LibraryImport(LIB)]
    public static partial nint glfwGetWindowMonitor(GLFWwindow window);
    [LibraryImport(LIB)]
    public static partial void glfwSetWindowMonitor(GLFWwindow window, GLFWmonitor monitor, int xpos, int ypos, int width, int height, int refreshRate);
    [LibraryImport(LIB)]
    public static partial int glfwGetWindowAttrib(GLFWwindow window, int attrib);
    [LibraryImport(LIB)]
    public static partial void glfwSetWindowAttrib(GLFWwindow window, int attrib, int value);
    [LibraryImport(LIB)]
    public static partial void glfwSetWindowUserPointer(GLFWwindow window, nint pointer);
    [LibraryImport(LIB)]
    public static partial nint glfwGetWindowUserPointer(GLFWwindow window);
    [LibraryImport(LIB)]
    public static partial GLFWwindowposfun glfwSetWindowPosCallback(GLFWwindow window, GLFWwindowposfun callback);
    [LibraryImport(LIB)]
    public static partial GLFWwindowsizefun glfwSetWindowSizeCallback(GLFWwindow window, GLFWwindowsizefun callback);
    [LibraryImport(LIB)]
    public static partial GLFWwindowclosefun glfwSetWindowCloseCallback(GLFWwindow window, GLFWwindowclosefun callback);
    [LibraryImport(LIB)]
    public static partial GLFWwindowrefreshfun glfwSetWindowRefreshCallback(GLFWwindow window, GLFWwindowrefreshfun callback);
    [LibraryImport(LIB)]
    public static partial GLFWwindowfocusfun glfwSetWindowFocusCallback(GLFWwindow window, GLFWwindowfocusfun callback);
    [LibraryImport(LIB)]
    public static partial GLFWwindowiconifyfun glfwSetWindowIconifyCallback(GLFWwindow window, GLFWwindowiconifyfun callback);
    [LibraryImport(LIB)]
    public static partial GLFWwindowmaximizefun glfwSetWindowMaximizeCallback(GLFWwindow window, GLFWwindowmaximizefun callback);
    [LibraryImport(LIB)]
    public static partial GLFWframebuffersizefun glfwSetWindowFramebufferSizeCallback(GLFWwindow window, GLFWframebuffersizefun callback);
    [LibraryImport(LIB)]
    public static partial GLFWwindowcontentsscalefun glfwSetWindowContentScaleCallback(GLFWwindow window, GLFWwindowcontentsscalefun callback);
    [LibraryImport(LIB)]
    public static partial void glfwPollEvents();
    [LibraryImport(LIB)]
    public static partial void glfwWaitEvents();
    [LibraryImport(LIB)]
    public static partial void glfwWaitEventsTimeout(double timeout);
    [LibraryImport(LIB)]
    public static partial void glfwPostEmptyEvent();
    [LibraryImport(LIB)]
    public static partial int glfwGetInputMode(GLFWwindow window, int mode);
    [LibraryImport(LIB)]
    public static partial void glfwSetInputMode(GLFWwindow window, int mode, int value);
    [LibraryImport(LIB)]
    public static partial int glfwRawMouseMotionSupported();
    [LibraryImport(LIB)]
    [return: MarshalAs(UnmanagedType.LPUTF8Str)]
    public static partial string glfwGetKeyName(int key, int scancode);
    [LibraryImport(LIB)]
    public static partial int glfwGetKeyScancode(int key);
    [LibraryImport(LIB)]
    public static partial int glfwGetKey(GLFWwindow window, int key);
    [LibraryImport(LIB)]
    public static partial int glfwGetMouseButton(GLFWwindow window, int button);
    [LibraryImport(LIB)]
    public static partial void glfwGetCursorPos(GLFWwindow window, out double xpos, out double ypos);
    [LibraryImport(LIB)]
    public static partial void glfwSetCursorPos(GLFWwindow window, double xpos, double ypos);
    [LibraryImport(LIB)]
    public static partial GLFWcursor glfwCreateCursor(GLFWimage image, int xhot, int yhot);
    [LibraryImport(LIB)]
    public static partial nint glfwCreateStandardCursor(int shape);
    [LibraryImport(LIB)]
    public static partial void glfwDestroyCursor(GLFWcursor cursor);
    [LibraryImport(LIB)]
    public static partial void glfwSetCursor(GLFWwindow window, GLFWcursor cursor);
    [LibraryImport(LIB)]
    public static partial GLFWkeyfun glfwSetKeyCallback(GLFWwindow window, GLFWkeyfun callback);
    [LibraryImport(LIB)]
    public static partial GLFWcharfun glfwSetCharCallback(GLFWwindow window, GLFWcharfun callback);
    [LibraryImport(LIB)]
    public static partial GLFWcharmodsfun glfwSetCharModsCallback(GLFWwindow window, GLFWcharmodsfun callback);
    [LibraryImport(LIB)]
    public static partial GLFWmousebuttonfun glfwSetMouseButtonCallback(GLFWwindow window, GLFWmousebuttonfun callback);
    [LibraryImport(LIB)]
    public static partial GLFWcursorposfun glfwSetCursorPosCallback(GLFWwindow window, GLFWcursorposfun callback);
    [LibraryImport(LIB)]
    public static partial GLFWcursorenterfun glfwSetCursorEnterCallback(GLFWwindow window, GLFWcursorenterfun callback);
    [LibraryImport(LIB)]
    public static partial GLFWscrollfun glfwSetScrollCallback(GLFWwindow window, GLFWscrollfun callback);
    [LibraryImport(LIB)]
    public static partial GLFWdropfun glfwSetDropCallback(GLFWwindow window, GLFWdropfun callback);
    [LibraryImport(LIB)]
    public static partial int glfwJoystickPresent(int jid);
    [LibraryImport(LIB)]
    [return: MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)]
    public static partial float[] glfwGetJoystickAxes(int jid, out int count);
    [LibraryImport(LIB)]
    [return: MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)]
    public static partial byte[] glfwGetJoystickButtons(int jid, out int count);
    [LibraryImport(LIB)]
    [return: MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)]
    public static partial byte[] glfwGetJoystickHats(int jid, out int count);
    [LibraryImport(LIB)]
    [return: MarshalAs(UnmanagedType.LPUTF8Str)]
    public static partial string glfwGetJoystickName(int jid);
    [LibraryImport(LIB)]
    [return: MarshalAs(UnmanagedType.LPUTF8Str)]
    public static partial string glfwGetJoystickGUID(int jid);
    [LibraryImport(LIB)]
    public static partial void glfwSetJoystickUserPointer(int jid, nint pointer);
    [LibraryImport(LIB)]
    public static partial nint glfwGetJoystickUserPointer(int jid);
    [LibraryImport(LIB)]
    public static partial int glfwJoystickIsGamepad(int jid);
    [LibraryImport(LIB)]
    public static partial GLFWjoystickfun glfwSetJoystickCallback(GLFWjoystickfun callback);
    [LibraryImport(LIB)]
    public static partial int glfwUpdateGamepadMappings([MarshalAs(UnmanagedType.LPStr)] string @string);
    [LibraryImport(LIB)]
    [return: MarshalAs(UnmanagedType.LPUTF8Str)]
    public static partial string glfwGetGamepadName(int jid);
    [LibraryImport(LIB)]
    public static partial int glfwGetGamepadState(int jid, GLFWgamepadstate state);
    [LibraryImport(LIB)]
    public static partial void glfwSetClipboardString(GLFWwindow window, [MarshalAs(UnmanagedType.LPUTF8Str)] string @string);
    [LibraryImport(LIB)]
    [return: MarshalAs(UnmanagedType.LPUTF8Str)]
    public static partial string glfwGetClipboardString(GLFWwindow window);
    [LibraryImport(LIB)]
    public static partial double glfwGetTime();
    [LibraryImport(LIB)]
    public static partial void glfwSetTime(double time);
    [LibraryImport(LIB)]
    public static partial ulong glfwGetTimerValue();
    [LibraryImport(LIB)]
    public static partial ulong glfwGetTimerFrequency();
    [LibraryImport(LIB)]
    public static partial void glfwMakeContextCurrent(GLFWwindow window);
    [LibraryImport(LIB)]
    public static partial GLFWwindow glfwGetCurrentContext();
    [LibraryImport(LIB)]
    public static partial void glfwSwapBuffers(GLFWwindow window);
    [LibraryImport(LIB)]
    public static partial void glfwSwapInterval(int interval);
    [LibraryImport(LIB)]
    public static partial int glfwExtensionSupported([MarshalAs(UnmanagedType.LPStr)] string extension);
    [LibraryImport(LIB)]
    public static partial nint glfwGetProcAddress([MarshalAs(UnmanagedType.LPStr)] string procname);
    [LibraryImport(LIB)]
    public static partial int glfwVulkanSupported();
    [LibraryImport(LIB)]
    [return: MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPStr, SizeParamIndex = 0)]
    public static partial string[] glfwGetRequiredInstanceExtensions(out uint count);
    [LibraryImport(LIB)]
    public static partial nint glfwGetInstanceProcAddress(nint instance, [MarshalAs(UnmanagedType.LPStr)] string procname);
    [LibraryImport(LIB)]
    public static partial int glfwGetPhysicalDevicePresentationSupport(nint instance, nint device, uint queuefamily);
    [LibraryImport(LIB)]
    public static partial nint glfwCreateWindowSurface(nint instance, GLFWwindow window, nint allocator, nint surface);
}
