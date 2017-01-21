using System;
using System.Threading;
using System.Collections.Generic;

namespace Sparrow
{
    /// <summary>
    /// Engine contains the core of sparrow.
    /// </summary>
    /// <remarks>
    /// It is responsible for continuously generating FrameState objects.
    /// Frame states are then passed to the action delegate which is responsible
    /// for marshalling the subsystems within the engine.
    /// </remarks>
    public class Engine
    {
        /// <summary>
        /// action is the main function to be called by the gameloop.
        /// </summary>
        public Action<FrameState> action;

        /// <summary>
        /// frameGenerator returns a new frame state object on each loop.
        /// </summary>
        private IEnumerable<FrameState> frameGenerator = new FrameGenerator();

        /// <summary>
        /// Loop is the main game loop
        /// </summary>
        public void Loop()
        {
            foreach (var frame in frameGenerator)
            {
                action(frame);
                Thread.Sleep(1);
            }
        }
    }
}
