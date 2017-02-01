using System;
using System.Collections.Generic;
using Sparrow.Pipelines;
using Sparrow.Sdl2;

namespace Sparrow.Events
{
    public class EventPipeline : VariableRatePipeline
    {
        
        public EventPipeline()
        {
            actions = new Dictionary<Type, Action<object>>();
        }
    
        private EventQueue eventQueue = new EventQueue();

        private Dictionary<Type, Action<object>> actions;

        public override void ProcessFrame(FrameState frame)
        {
            foreach (var evt in eventQueue)
            {
                Type type = evt.GetType();
                if (!actions.ContainsKey(type)) continue;
                actions[type](evt);
            }
        }
        
        public void Subscribe<T>(Action<T> action) where T:struct
        {
            const string message = "Cannot subscribe to an event that has already been subscribed to.";
            Type type = typeof(T);
            if (actions.ContainsKey(type)) throw new Exception(message);
            actions.Add(type, (e) => action((T)e));
        }
                
        public void Unsubscribe<T>() where T:struct
        {
            const string message = "Cannot unsubscribe from an event without first having a subscription.";
            Type type = typeof(T);
            if (!actions.ContainsKey(type)) throw new Exception(message);
            actions.Remove(type);
        }
    }
}