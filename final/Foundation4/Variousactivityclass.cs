using System;

    class RunningActivity : Activity
    {
        private double distance;

        public RunningActivity(DateTime date, int minutes, double distance) : base(date, minutes)
        {
            this.distance = distance;
        }

        public override double GetDistance()
        {
            return distance;
        }

        public override double GetSpeed()
        {
            return distance / (double)minutes * 60 * 0.62; // miles per hour
        }

        public override double GetPace()
        {
            return (double)minutes / distance;
        }
    }

    class CyclingActivity : Activity
    {
        private double speed;

        public CyclingActivity(DateTime date, int minutes, double speed) : base(date, minutes)
        {
            this.speed = speed;
        }

        public override double GetSpeed()
        {
            return speed;
        }

        public override double GetDistance()
        {
            return speed / 60 * (double)minutes;
        }

        public override double GetPace()
        {
            return 60 / speed;
        }
    }

    class SwimmingActivity : Activity
    {
        private int laps;

        public SwimmingActivity(DateTime date, int minutes, int laps) : base(date, minutes)
        {
            this.laps = laps;
        }

        public override double GetDistance()
        {
            return laps * 50 / 1000.0; // kilometers
        }

        public override double GetSpeed()
        {
            return GetDistance() / (double)minutes * 60; // kilometers per hour
        }

        public override double GetPace()
        {
            return (double)minutes / GetDistance();
        }