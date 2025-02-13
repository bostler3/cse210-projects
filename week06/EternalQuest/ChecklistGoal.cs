public class ChecklistGoal : Goal
{
    private int _target;
    private int _bonus;

    // Constructor
    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public override int GetBonusPoints()
    {
        return _bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted += 1;

        if (IsComplete() == true)
        {
            BonusCompletionMessage();
            Console.WriteLine($"You have earned {_points + _bonus} points, which includes {_bonus} bonus points for completing the Checklist Goal!");
        }
        else
        {
            CompletionMessage();
            Console.WriteLine($"You have earned {_points} points!");
        }
    }

    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
        {
            return true;   
        }
        else
        {
            return false;
        }
    }

    public override string GetDetailsString()
    {
        string completeSymbol = " ";
        if (IsComplete())
        {
            completeSymbol = "X";
        }
        return $"[{completeSymbol}] {_shortName} ({_description}) -- Progress: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName}|{_description}|{_points}|{_amountCompleted}|{IsComplete()}|{_bonus}|{_target}";
    }

    public void BonusCompletionMessage()
    {
        string text = "Congratulations! BONUS Points!";
        int flashCount = 5;
        int delay = 500;

        for (int i = 0; i < flashCount; i++)
        {
            Console.Clear();
            if (i % 2 == 0)
            {
                Console.WriteLine(text);
            }
            Thread.Sleep(delay);
        }
        Console.Clear();
        Console.WriteLine(text);
    }
}