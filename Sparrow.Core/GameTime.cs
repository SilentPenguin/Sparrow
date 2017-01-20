using System;

namespace Sparrow
{
    public class GameTime
    {   
        public GameTime() : this(DateTime.UtcNow) {}
        public GameTime(DateTime epoch) { Now = Epoch = epoch; }
        public GameTime(GameTime time)
        {
            Epoch = time.Epoch;
            Now = time.Now;
            Elapsed = time.Elapsed;
            Step = time.Step;
        }

        public DateTime Epoch { get; protected set; }
        public DateTime Now { get; protected set; } 
        public TimeSpan Elapsed { get; protected set; }
        public TimeSpan Step { get; protected set; }

        public virtual void Increment(TimeSpan period)
        {
            Now += period;
            Elapsed += period;
            Step = period;
        }

        public static GameTime operator +(GameTime time, TimeSpan period)
        {
            var result = new GameTime(time);
            result.Increment(period);
            return result;
        }

        public static TimeSpan operator -(GameTime a, GameTime b) { return a.Now - b.Now; }
        public static bool operator >(GameTime a, GameTime b) { return a.Now > b.Now; }
        public static bool operator <(GameTime a, GameTime b) { return a.Now < b.Now; }
        public static bool operator >=(GameTime a, GameTime b) { return a.Now >= b.Now; }
        public static bool operator <=(GameTime a, GameTime b) { return a.Now <= b.Now; }
    }
}