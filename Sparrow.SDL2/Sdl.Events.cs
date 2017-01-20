using System;
using System.Runtime.InteropServices;

namespace Sparrow.Sdl
{
    public static partial class Sdl
    {

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

        [StructLayout(LayoutKind.Sequential)]
		public struct QuitEvent
		{
			public EventType type;
			public UInt32 timestamp;
		}

		[StructLayout(LayoutKind.Explicit)]
		public struct Event
		{
			[FieldOffset(0)]
			public EventType type;
			/*
            [FieldOffset(0)]
			public WindowEvent window;
			[FieldOffset(0)]
			public KeyboardEvent key;
			[FieldOffset(0)]
			public TextEditingEvent edit;
			[FieldOffset(0)]
			public TextInputEvent text;
			[FieldOffset(0)]
			public MouseMotionEvent motion;
			[FieldOffset(0)]
			public MouseButtonEvent button;
			[FieldOffset(0)]
			public MouseWheelEvent wheel;
			[FieldOffset(0)]
			public JoyAxisEvent jaxis;
			[FieldOffset(0)]
			public JoyBallEvent jball;
			[FieldOffset(0)]
			public JoyHatEvent jhat;
			[FieldOffset(0)]
			public JoyButtonEvent jbutton;
			[FieldOffset(0)]
			public JoyDeviceEvent jdevice;
			[FieldOffset(0)]
			public ControllerAxisEvent caxis;
			[FieldOffset(0)]
			public ControllerButtonEvent cbutton;
			[FieldOffset(0)]
			public ControllerDeviceEvent cdevice;
            */
			[FieldOffset(0)]
			public QuitEvent quit;
            /*
			[FieldOffset(0)]
			public UserEvent user;
			[FieldOffset(0)]
			public SysWMEvent syswm;
			[FieldOffset(0)]
			public TouchFingerEvent tfinger;
			[FieldOffset(0)]
			public MultiGestureEvent mgesture;
			[FieldOffset(0)]
			public DollarGestureEvent dgesture;
			[FieldOffset(0)]
			public DropEvent drop;
            */
		}

        [DllImport(DllName, EntryPoint = "SDL_PollEvent")]
        public static extern uint PollEvent(out Event _event);
    }
}