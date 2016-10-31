using System;

namespace Engine.Messages
{
    public class Receiver<T> : IReceiver<T>
    {
        public Receiver (Action<T> action)
        {
            Action = action;
        }

        private Action<T> Action { get; set; }
        public void Receive(T value) { Action(value); }
    }
}