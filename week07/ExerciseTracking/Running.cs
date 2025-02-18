public class Running : Activity
{
    private double _distance;

    // Constructor
    public Running(string date, string activityName, int duration, double distance) : base(date, activityName, duration)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        double speed = (_distance / _duration) * 60;
        return speed;
    }

    public override double GetPace()
    {
        double pace = _duration / _distance;
        return pace;
    }
}