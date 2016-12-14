using System;

namespace Sparrow
{
    public class ScaledGameTime : GameTime
    {
        public ScaledGameTime() : base(DateTime.UtcNow) {}
        public ScaledGameTime(DateTime epoch) : base(epoch) {}
        public ScaledGameTime(GameTime time) : base(time) {}
        public ScaledGameTime(ScaledGameTime time) : base(time) { Scale = time.Scale; }

        public double Scale { get; set; } = 1;
        public bool IsStopped { get { return Scale == 0; } }

        public override void Increment(TimeSpan period)
        {
            period = TimeSpan.FromTicks((long)(period.Ticks * Scale));
            base.Increment(period);
        }

        public static ScaledGameTime operator +(ScaledGameTime time, TimeSpan period)
        {
            var result = new ScaledGameTime(time);
            result.Increment(period);
            return result;
        }
    }
}