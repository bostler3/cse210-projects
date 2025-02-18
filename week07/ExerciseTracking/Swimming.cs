public class Swimming : Activity
{
    private double _numberOfLaps;

    // Constructor
    public Swimming(string date, string activityName, int duration, double numberOfLaps) : base(date, activityName, duration)
    {
        _numberOfLaps = numberOfLaps;
    }

    public override double GetDistance()
    {
        double distance = _numberOfLaps * 50 / 1000 * 0.62;
        return distance;
    }

    public override double GetSpeed()
    {
        double speed = 60 / GetPace();
        return speed;
    }

    public override double GetPace()
    {
        double pace = _duration / GetDistance();
        return pace;
    }
}