using System;

namespace Sparrow
{
    public class GameTime
    {   
        public GameTime() : this(DateTime.UtcNow) {}
        public GameTime(DateTime epoch){ Epoch = epoch; }

        public DateTime Epoch { get; private set; }
        public DateTime Now { get; private set; }
        public TimeSpan Elapsed { get; private set; }
        public double Speed { get; set; }
        public bool IsPaused { get { return Speed == 0; } }

        public void Increment(TimeSpan period)
        {
            period = Scale(period, Speed);
            Now += period;
            Elapsed += period;
        }

        private static TimeSpan Scale(TimeSpan period, double speed)
        {
            return TimeSpan.FromTicks((long)(period.Ticks * speed));
        }
    }
}