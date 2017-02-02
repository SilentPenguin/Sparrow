using System;
using System.Linq;
using System.Reflection;
using System.Collections.Generic;
using Sparrow.Pipelines;
using Sparrow.Sdl2;

namespace Sparrow.Events
{
    /// <summary>
    /// The EventPipeline is an structure for outputting application events
    /// events generated during runtime.
    /// </summary>
    /// <remarks>
    /// Applications utilising the EventPipeline usually attach a single action
    /// to the pipeline via <see cref='Subscribe()'/>.
    /// A subscription can accept any <see cref='Event'/>, but only one
    /// action can be used for each subscribed type. This restriction excends to
    /// subtypes, meaning a subscription to <see cref='Event'/> would block the
    /// creation of any subscriptions to <see cref='KeyboardEvent'/>.
    /// It is typically attached to the <see cref='Engine'/> via a
    /// <see cref='SequenatialPipeline'/> as the first pipeline, before any
    /// other pipelines to reduce latency.
    /// </remarks>
    public class EventPipeline : VariableRatePipeline
    {

        public EventPipeline()
        {
            actions = new Dictionary<Type, Action<Event>>();
        }

        private EventQueue eventQueue = new EventQueue();
        private Dictionary<Type, Action<Event>> actions;
        private static IEnumerable<Type> eventTypes = new List<Type>
        {
            typeof(QuitEvent),
            typeof(KeyboardEvent),
        };

        public override void ProcessFrame(FrameState frame)
        {
            Action<Event> action;

            foreach (var evt in eventQueue)
            {
                var type = evt.GetType();
                if (!actions.TryGetValue(type, out action)) continue;
                action(evt);
            }
        }

        /// <summary>
        /// Subscribes an action to handle a specific type of event.
        /// </summary>
        /// <remarks>
        /// The action will be called for every instance of that event being
        /// generated, including base types.
        /// Will throw an exception if an action is already subscribed to the
        /// given type or any of it's subtypes.
        /// This means calling Subscribe<Event>(handleAllEvents) would consume
        /// all possible subscriptions for the given event.
        /// </remarks>
        public void Subscribe<T>(Action<T> action) where T:Event
        {
            const string message = "Cannot subscribe to an event that has already been subscribed to.";
            var Ttype = typeof(T).GetTypeInfo();
            var types = eventTypes.Where(type => Ttype.IsAssignableFrom(type.GetTypeInfo()));
            foreach(var type in types)
            {
                if (actions.ContainsKey(type)) throw new Exception(message);
                actions.Add(type, (e) => action((T)e));
            }
        }

        /// <summary>
        /// Unsubscribes a subscribed action
        /// </summary>
        /// <remarks>
        /// Will throw an exception if the event type is not registered.
        /// Previously subscribed events can be partially unsubscribed.
        /// Calling Subscribe<Event>(handleAllEvents);
        /// followed by Unsubscribe<KeyboardEvent>(); would unsubscribe the
        /// action handleAllEvents from KeyboardEvents only.This would make
        /// KeyboardEvent available to be subscribed to again.
        /// </remarks>
        public void Unsubscribe<T>() where T:Event
        {
            const string message = "Cannot unsubscribe from an event without first having a subscription.";
            var types = eventTypes.Where(type => type.GetTypeInfo().IsAssignableFrom(typeof(T)));
            foreach(var type in types)
            {
                if (!actions.ContainsKey(type)) throw new Exception(message);
                actions.Remove(type);
            }
        }
    }
}