using System.Runtime.InteropServices;

namespace Sparrow.Glfw;

public partial class Lib
{
    [StructLayout(LayoutKind.Sequential)]
    public struct GLFWmonitor
    {
        public static readonly GLFWmonitor Zero;
        readonly nint _;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct GLFWwindow
    {
        public static readonly GLFWwindow Zero;
        readonly nint _;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct GLFWcursor
    {
        readonly nint _;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct GLFWvidmode
    {
        public int width, height;
        public int redBits, greenBits, blueBits;
        public int refreshRate;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct GLFWgammaramp
    {
        public nint red, green, blue;
        public int size;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct GLFWimage
    {
        public int width, height;
        public nint pixels;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct GLFWgamepadstate
    {
        public nint states;
        public nint axes;
    }
}
