public class EternalGoal : Goal
{
    // Constructor
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {

    }

    public override void RecordEvent()
    {
        _amountCompleted += 1;
        CompletionMessage();
        Console.WriteLine($"You have earned {_points} points!");
    }

    public override bool IsComplete()
    {
        // Always false because Eternal Goals are never completed
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName}|{_description}|{_points}|{_amountCompleted}|{IsComplete()}";
    }
}