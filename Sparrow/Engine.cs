using System;
using System.Threading;
using System.Collections.Generic;

namespace Sparrow
{
    /// <summary>
    /// Engine<T> contains the core of sparrow.
    /// </summary>
    /// <remarks>
    /// It is responsible for continuously generating FrameState objects.
    /// Frame states are then passed to the action delegate which is responsible
    /// for marshalling the subsystems within the engine.
    /// </remarks>
    public class Engine<T>
    {
        /// <summary>
        /// action is the main function to be called by the gameloop.
        /// </summary>
        public Action<T> action;

        /// <summary>
        /// generator returns a new frame state object on each loop.
        /// </summary>
        public IEnumerable<T> generator;

        /// <summary>
        /// Loop is the main game loop.
        /// </summary>
        /// <remarks>
        /// Loop will consume the current thread until the generator stops iteration.
        /// </remarks>
        public void Loop()
        {
            foreach (var frame in generator)
            {
                action(frame);
                Thread.Sleep(1);
            }
        }
    }
}
