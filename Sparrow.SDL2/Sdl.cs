using System;
using System.Runtime.InteropServices;

namespace Sparrow.Sdl2
{

    public static partial class Sdl
    {
        private const string DllName = "/Library/Frameworks/SDL2.framework/SDL2";

        /// <summary>
		/// Flags accepted by <see cref="Init()"/>, <see cref="InitSubSystem()"/>, <see cref="QuitSubSystem()"/>, and <see cref="WasInit()"/>
		/// </summary>
        /// <seealso cref="Init()"/>
        /// <seealso cref="InitSubSystem()"/>
        /// <seealso cref="QuitSubSystem()"/>
        /// <seealso cref="WasInit()"/>
        [Flags]
        public enum InitFlag : UInt32
        {
            Timer =             0x00000001,
            Audio =             0x00000010,
            Video =             0x00000020,
            Joystick =          0x00000200,
            Haptic =            0x00001000,
            GameController =    0x00002000,
            Events =            0x00004000,
            NoParachute =       0x00100000,
            Everything =        0x00007231
        }
        
        /// <summary>
		/// Initialize the SDL library.
		/// This must be called before using any other SDL function.
		/// </summary>
        /// <param name="flags">Subsystem initialization flags.</param>
        /// <returns>Returns 0 on success or a negative error code on failure.</returns>
        /// <remarks>
        /// <see cref='Init()'/> simply forwards to calling <see cref='InitSubSystem()'/>. Therefore, the two may be used interchangeably.
        /// Though for readability of your code <see cref='InitSubSystem()'/> might be preferred.
        /// If you want to initialize subsystems separately you would call <see cref='Init()'/> followed by <see cref='InitSubSystem()'/> with the desired subsystem flag.
        /// </remarks>
        /// <seealso cref="InitSubSystem()"/>
        /// <seealso cref="Quit()"/>        
        /// <seealso cref="SetMainReady()"/>
        /// <seealso cref="WasInit()"/>
        [DllImport(DllName, EntryPoint = "SDL_Init")]
        public static extern UInt32 Init(InitFlag flags = 0);
        
        /// <summary>
        /// Initialize specific SDL subsystems.
        /// </summary>
        /// <param name="flags">Any of the flags used by <see cref='Init()'/>.</param>
        /// <returns>success or a negative error code on failure.</returns>
        /// <remarks>
        /// <see cref='Init()'/> initializes assertions and crash protection and then calls <see cref='InitSubSystem()'/>.
        /// If you want to bypass those protections you can call <see cref='InitSubSystem()'/> directly.
        /// Subsystem initialization is ref-counted, you must call <see cref='QuitSubSystem()'/> for each <see cref='InitSubSystem()'/> to correctly shutdown a subsystem manually (or call <see cref='Quit()'/> to force shutdown).
        /// If a subsystem is already loaded then this call will increase the ref-count and return.
        /// </remarks>
        /// <seealso cref="Init()"/>
        /// <seealso cref="Quit()"/>        
        /// <seealso cref="QuitSubSystem()"/>
        [DllImport(DllName, EntryPoint = "SDL_InitSubSystem")]
        public static extern UInt32 InitSubSystem(InitFlag flags);
        
        /// <summary>
        /// Shut down specific SDL subsystems.
        /// </summary>
        /// <param name="flags">Any of the flags used by <see cref='Init()'/>.</param>
        /// <remarks>
        /// If you start a subsystem using a call to that subsystem's init function (for example <see cref='VideoInit()'/>) instead of <see cref='Init()'/> or <see cref='InitSubSystem()'/> then <see cref='QuitSubSystem()'/> and <see cref='SDL_WasInit()'/> will not work.
        /// You will need to use that subsystem's quit function (<see cref='VideoQuit()'/>) directly instead.
        /// You still need to call <see cref='Quit()'/> even if you close all open subsystems with <see cref='QuitSubSystem()'/>.</remarks>
        /// <seealso cref="InitSubSystem()"/>
        /// <seealso cref="Quit()"/>
        [DllImport(DllName, EntryPoint = "SDL_InitSubSystem")]
        public static extern void QuitSubSystem(InitFlag flags);

        /// <summary>
        /// Get a mask of the specified subsystems which have previously been initialized.
        /// </summary>
        /// <param name="flags">Any of the flags used by <see cref='Init()'/>.</param>
        /// <returns>
        /// If flags is 0 it returns a mask of all initialized subsystems,
        /// otherwise it returns the initialization status of the specified subsystems.
        /// The return value does not include <see cref='InitFlags.NoParachute'/>.
        /// </returns>
        /// <seealso cref="Init()"/>
        /// <seealso cref="InitSubSystem()"/>
        [DllImport(DllName, EntryPoint = "SDL_InitSubSystem")]
        public static extern UInt32 WasInit(InitFlag flags=0);

        /// <summary>
        /// Clean up all initialized subsystems.
        /// You should call it upon all exit conditions.
        /// </summary>
        /// <remarks>
        /// You should call this function even if you have already shutdown each initialized subsystem with SDL_QuitSubSystem().
        /// It is safe to call this function even in the case of errors in initialization.
        /// If you start a subsystem using a call to that subsystem's init function (for example <see cref='VideoInit()'/>) instead of <see cref='Init()'/> or <see cref='InitSubSystem()'/>,
        /// then you must use that subsystem's quit function (<see cref='VideoQuit()'/>) to shut it down before calling <see cref='Quit()'/>.
        /// </remarks>
        /// <seealso cref="Init()"/>
        /// <seealso cref="QuitSubSystem()"/>
        [DllImport(DllName, EntryPoint = "SDL_Quit")]
        public static extern void Quit();
    }
}