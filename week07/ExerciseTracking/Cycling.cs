public class Cycling : Activity
{
    private double _speed;

    // Constructor
    public Cycling(string date, string activityName, int duration, double speed) : base(date, activityName, duration)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        double distance = (_speed * _duration) / 60;
        return distance;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        double pace = 60 / _speed;
        return pace;
    }
}