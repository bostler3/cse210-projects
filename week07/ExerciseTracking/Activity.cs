public abstract class Activity
{
    private string _date;
    private string _activityName;
    protected int _duration;
   
    public Activity(string date, string activityName, int duration)
    {
        _date = date;
        _activityName = activityName;
        _duration = duration;
    }
   
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
   
    public string GetSummary()
    {
        return $"{_date} {_activityName} ({_duration} min) - Distance: {GetDistance():0.0} miles, Speed: {GetSpeed():0.0} mph, Pace:  {GetPace():0.0} min per mile"; //Got help for formatting from here: https://codebuns.com/csharp-basics/numeric-formats/
    }
}