  using System;
  
  abstract class Activity
    {
        private DateTime date;
        private int minutes;

        public Activity(DateTime date, int minutes)
        {
            this.date = date;
            this.minutes = minutes;
        }

        public virtual double GetDistance()
        {
            return 0;
        }

        public virtual double GetSpeed()
        {
            return 0;
        }

        public virtual double GetPace()
        {
            return 0;
        }

        public string GetSummary()
        {
            return $"{date.ToString("dd MMM yyyy")} {GetType().Name} ({minutes} min) - Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min/km";
        }
    }