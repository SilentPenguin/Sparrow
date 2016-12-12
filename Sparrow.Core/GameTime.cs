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
            Speed = time.Speed;
        }

        public DateTime Epoch { get; private set; }
        public DateTime Now { get; private set; } 
        public TimeSpan Elapsed { get; private set; }
        public TimeSpan Step { get; private set; }
        public double Speed { get; set; }
        public bool IsPaused { get { return Speed == 0; } }

        public void Increment(TimeSpan period)
        {
            Step = Scale(period, Speed);
            Now += Step;
            Elapsed += Step;
        }

        private static TimeSpan Scale(TimeSpan period, double speed)
        {
            return TimeSpan.FromTicks((long)(period.Ticks * speed));
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