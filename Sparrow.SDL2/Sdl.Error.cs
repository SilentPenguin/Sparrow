using System.Runtime.InteropServices;

namespace Sparrow.Sdl2
{
    public static partial class Sdl
    {
        /// <summary>
        /// Retrieve a message about the last error that occurred.
        /// </summary>
        /// <returns>
        /// Returns a message with information about the specific error that occurred,
        /// or an empty string if there hasn't been an error message set since the last call to <see cref='ClearError()'/>.
        /// The message is only applicable when an SDL function has signaled an error.
        /// You must check the return values of SDL function calls to determine when to appropriately call <see cref='GetError()'/>.
        /// </returns>
        /// <seealso cref="ClearError()"/>
        /// <seealso cref="SetError()"/>
        [DllImport(DllName, EntryPoint = "SDL_GetError")]
        public static extern string GetError();
    }
}
