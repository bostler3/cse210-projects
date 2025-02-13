public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;
    protected int _amountCompleted;

    // Constructor
    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _amountCompleted = 0;
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        string completeSymbol = " ";

        if (IsComplete())
        {
            completeSymbol = "X";
        }
        return $"[{completeSymbol}] {_shortName} ({_description})";
    }

    public abstract string GetStringRepresentation();

    // Additional methods
    public string GetName()
    {
        return _shortName;
    }

    public int GetPoints()
    {
        return _points;
    }

    public void SetAmountCompleted(int amountCompleted)
    {
        _amountCompleted = amountCompleted;
    }

    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }

    public virtual int GetBonusPoints()
    {
        return 0;
    }

    public void CompletionMessage()
    {
        // Got help with this animation from a Bing search for "make text flash console c#"
        string text = "Congratulations!";
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