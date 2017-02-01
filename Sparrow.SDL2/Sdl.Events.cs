using System;
using System.Runtime.InteropServices;

namespace Sparrow.Sdl2
{
    public static partial class Sdl
    {
        /// <summary>
		/// Event type codes returned within <see cref='Event'/>
		/// </summary>
        /// <seealso cref="Event"/>
        public enum EventType : uint
        {
            FirstEvent = 0,

            /* Application events */
            Quit = 0x100,

            /* Window events */
            WindowEvent = 0x200,
            SysWmEvent,

            /* Keyboard events */
            KeyDown = 0x300,
            KeyUp,
            TextEditing,
            TextInput,

            /* Mouse events */
            MouseMotion = 0x400,
            MouseButtonDown,
            MouseButtonUp,
            MouseWheel,

            /* Joystick events */
            JoyAxisMotion = 0x600,
            JoyBallMotion,
            JoyHatMotion,
            JoyButtonDown,
            JoyButtonUp,
            JoyDeviceAdded,
            JoyDeviceRemoved,

            /* Game controller events */
            ControllerAxisMotion = 0x650,
            ControllerButtonDown,
            ControllerButtonUp,
            ControllerDeviceAdded,
            ControllerDeviceRemoved,
            ControllerDeviceRemapped,

            /* Touch events */
            FingerDown = 0x700,
            FingerUp,
            FingerMotion,

            /* Gesture events */
            DollarGesture = 0x800,
            DollarRecord,
            MultiGesture,

            /* Clipboard events */
            ClipboardUpdate = 0x900,

            /* Drag and drop events */
            DropFile = 0x1000,
            /* Only available in 2.0.4 or higher */
            DropText,
            DropBegin,
            DropComplete,

            /* Audio hotplug events */
            /* Only available in SDL 2.0.4 or higher */
            AudioDeviceAdded = 0x1100,
            AudioDeviceRemoved,

            /* Render events */
            /* Only available in SDL 2.0.2 or higher */
            RenderTargetsReset = 0x2000,
            /* Only available in SDL 2.0.4 or higher */
            RenderDeviceReset,

            /* Events SDL_USEREVENT through SDL_LASTEVENT are for
            * your use, and should be allocated with
            * SDL_RegisterEvents()
            */
            UserEvent = 0x8000,

            /* The last event, used for bouding arrays. */
            LastEvent = 0xFFFF
        }

        public enum MouseWheelDirection : uint
        {
            Normal,
            Flipped
        }

        [Flags]
        public enum MouseButton : byte
        {
            Left = 1 << 0,
            Middle = 1 << 1,
            Right = 1 << 2,
            X1 = 1 << 3,
            X2 = 1 << 4,
        }

        public enum ButtonState : byte
        {
            Pressed = 1,
            Released = 0,
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct KeySymbol
        {
            public Scancode scancode;
            public Keycode keycode;
            public KeyModifier modifers; /* UInt16 */
            public uint unicode; /* Deprecated */
        }

        /// <summary>
		/// The event returned when quit is requested
		/// </summary>
        /// <seealso cref="PollEvent()"/>
        [StructLayout(LayoutKind.Sequential)]
        public struct QuitEvent
        {
            public EventType type;
            public uint timestamp;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct KeyboardEvent
        {
            public EventType type;
            public uint timestamp;
            public uint windowId;
            public ButtonState state;
            public byte repeat; /* non-zero if this is a repeat */
            private byte padding2;
            private byte padding3;
            public KeySymbol keySymbol;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct MouseMotionEvent
        {
            public EventType type;
            public uint timestamp;
            public uint windowId;
            public uint which;
            public MouseButton state;
            private byte padding1;
            private byte padding2;
            private byte padding3;
            public int x;
            public int y;
            public int xrel;
            public int yrel;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct MouseButtonEvent
        {
            public EventType type;
            public uint timestamp;
            public uint windowId;
            public uint which;
            public MouseButton button;
            public ButtonState state;
            public byte clicks; /* click count */
            private byte padding1;
            public int x;
            public int y;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct MouseWheelEvent
        {
            public EventType type;
            public uint timestamp;
            public uint windowId;
            public uint which;
            public int x; /* amount scrolled horizontally */
            public int y; /* amount scrolled vertically */
            public MouseWheelDirection direction; /* Set to one of the SDL_MOUSEWHEEL_* defines */
        }
        
        [StructLayout(LayoutKind.Sequential)]
        public struct ControllerAxisEvent
        {
            public EventType type;
            public uint timestamp;
            public int which; /* SDL_JoystickID */
            public byte axis;
            private byte padding1;
            private byte padding2;
            private byte padding3;
            public short axisValue; /* value, lolC# */
            private ushort padding4;
        }
        
        [StructLayout(LayoutKind.Sequential)]
        public struct ControllerDeviceEvent
        {
            public EventType type;
            public uint timestamp;
            public int which;
        }
        
        [StructLayout(LayoutKind.Sequential)]
        public struct ControllerButtonEvent
        {
            public EventType type;
            public uint timestamp;
            public int which; /* SDL_JoystickID */
            public byte button;
            public byte state;
            private byte padding1;
            private byte padding2;
        }
        
        [StructLayout(LayoutKind.Sequential)]
        public struct CommonEvent
        {
            public EventType type;
            public uint timestamp;
        }
        
        /// <summary>
		/// The full event structure returned and used by <see cref='PollEvent()'/>
		/// </summary>
        /// <seealso cref="PollEvent()"/>
        [StructLayout(LayoutKind.Explicit, Size=56)]
        public struct Event
        {
            [FieldOffset(0)] public CommonEvent common;
            /*
            [FieldOffset(0)] public WindowEvent window;
            */
            [FieldOffset(0)] public KeyboardEvent key;
            /*
            [FieldOffset(0)] public TextEditingEvent edit;
            [FieldOffset(0)] public TextInputEvent text;
            */
            [FieldOffset(0)] public MouseMotionEvent motion;
            [FieldOffset(0)] public MouseButtonEvent button;
            [FieldOffset(0)] public MouseWheelEvent wheel;
            /*
            [FieldOffset(0)] public JoyAxisEvent jaxis;
            [FieldOffset(0)] public JoyBallEvent jball;
            [FieldOffset(0)] public JoyHatEvent jhat;
            [FieldOffset(0)] public JoyButtonEvent jbutton;
            [FieldOffset(0)] public JoyDeviceEvent jdevice;
            */
            [FieldOffset(0)] public ControllerAxisEvent caxis;
            [FieldOffset(0)] public ControllerButtonEvent cbutton;
            [FieldOffset(0)] public ControllerDeviceEvent cdevice;
            [FieldOffset(0)] public QuitEvent quit;
            /*
            [FieldOffset(0)] public UserEvent user;
            [FieldOffset(0)] public SysWMEvent syswm;
            [FieldOffset(0)] public TouchFingerEvent tfinger;
            [FieldOffset(0)] public MultiGestureEvent mgesture;
            [FieldOffset(0)] public DollarGestureEvent dgesture;
            [FieldOffset(0)] public DropEvent drop;
            */
        }

        /// <summary>
        /// Poll for currently pending events.
        /// </summary>
        /// <param name="@event">the <see cref='Event'/> structure to be filled with the next event from the queue, or null</param>
        /// <returns>Returns 1 if there is a pending event or 0 if there are none available.</returns>
        /// <remarks>
        /// If event is not null, the next event is removed from the queue and stored in the <see cref='Event'/> structure pointed to by event.
        /// If event is null, it simply returns 1 if there is an event in the queue, but will not remove it.
        /// As this function implicitly calls <see cref='PumpEvents()'/>, you can only call this function in the thread that set the video mode.
        /// <see cref='PollEvents()'/> is the favored way of receiving system events since it can be done from the main loop and does not suspend the main loop while waiting on an event to be posted.
        /// </remarks>
        /// <seealso cref="GetEventFilter()"/>
        /// <seealso cref="PeepEvents()"/>
        /// <seealso cref="PushEvent()"/>
        /// <seealso cref="SetEventFilter()"/>
        /// <seealso cref="WaitEvent()"/>
        /// <seealso cref="WaitEventTimeout()"/>
        [DllImport(DllName, EntryPoint = "SDL_PollEvent")]
        public static extern uint PollEvent(out Event @event);
    }
}