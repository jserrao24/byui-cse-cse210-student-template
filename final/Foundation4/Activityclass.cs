public abstract class Activity
{
    private DateTime date;
    public int durationInMinutes;

    public Activity(DateTime date, int durationInMinutes)
    {
        this.date = date;
        this.durationInMinutes = durationInMinutes;
    }

    public virtual double GetDistance()
    {
        return 0; // default implementation for activities without distance
    }

    public virtual double GetSpeed()
    {
        return 0; // default implementation for activities without speed
    }

    public virtual double GetPace()
    {
        return 0; // default implementation for activities without pace
    }

    public virtual string GetSummary()
    {
        return $"{date:d} {GetType().Name} ({durationInMinutes} min)";
    }
}

public class RunningActivity : Activity
{
    private double distance;

    public RunningActivity(DateTime date, int durationInMinutes, double distance)
        : base(date, durationInMinutes)
    {
        this.distance = distance;
    }

    public override double GetDistance()
    {
        return distance;
    }

    public override double GetSpeed()
    {
        return distance / durationInMinutes * 60;
    }

    public override double GetPace()
    {
        return durationInMinutes / distance;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()}: Distance {distance:f1} miles, Speed {GetSpeed():f1} mph, Pace: {GetPace():f1} min per mile";
    }
}

public class CyclingActivity : Activity
{
    private double speed;

    public CyclingActivity(DateTime date, int durationInMinutes, double speed)
        : base(date, durationInMinutes)
    {
        this.speed = speed;
    }

    public override double GetSpeed()
    {
        return speed;
    }

    public override double GetDistance()
    {
        return speed * durationInMinutes / 60;
    }

    public override double GetPace()
    {
        return 60 / speed;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()}: Distance {GetDistance():f1} km, Speed: {speed:f1} kph, Pace: {GetPace():f1} min per km";
    }
}

public class SwimmingActivity : Activity
{
    private int laps;

    public SwimmingActivity(DateTime date, int durationInMinutes, int laps)
        : base(date, durationInMinutes)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        return laps * 50.0 / 1000; // convert laps to km
    }

    public override double GetSpeed()
    {
        return GetDistance() / durationInMinutes * 60;
    }

    public override double GetPace()
    {
        return durationInMinutes / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()}: Distance {GetDistance():f1} km, Speed: {GetSpeed():f1} kph, Pace: {GetPace():f1} min per km";
    }
}