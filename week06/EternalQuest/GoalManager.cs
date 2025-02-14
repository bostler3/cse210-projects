public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
   
    // Constructor
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    // Exceeding
    public int CalculateNumberOfGoalsCompleted()
    {
        int numberOfGoalsCompleted = 0;
        int numberCompleted = 0;

        foreach (Goal goal in _goals)
        {
            numberCompleted = goal.GetAmountCompleted();
            numberOfGoalsCompleted += numberCompleted;
        }
        return numberOfGoalsCompleted;
    }

    // Exceeding
    public string CalculateLevel()
    {
        string level1 = "Strong Starter!";
        string level2 = "A Star in the Making!";
        string level3 = "Champion!";
        string level4 = "Elite!";
        int level1Max = 5;
        int level2Max = 10;
        int level3Max = 15;
        int numberOfGoalsCompleted = CalculateNumberOfGoalsCompleted();

        if (numberOfGoalsCompleted <= level1Max)
        {
            int numberOfGoalsLeft = level1Max + 1 - numberOfGoalsCompleted;
            return $"Achievement level based on that number of completed goals: {level1}\nComplete {numberOfGoalsLeft} more goals to get to the next level - you can do it!";
        }

        else if (numberOfGoalsCompleted <= level2Max)
        {
            int numberOfGoalsLeft = level2Max + 1 - numberOfGoalsCompleted;
            return $"Achievement level based on that number of completed goals: {level2}\nComplete {numberOfGoalsLeft} more goals to get to the next level - you can do it!";
        }

        else if (numberOfGoalsCompleted <= level3Max)
        {
            int numberOfGoalsLeft = level3Max + 1 - numberOfGoalsCompleted;
            return $"Achievement level based on that number of completed goals: {level3}\nComplete {numberOfGoalsLeft} more goals to get to the next level - you can do it!";
        }

        else
        {
            return $"Achievement level based on that number of completed goals: {level4}  That’s the highest level!";
        }
    }
   
    public void Start()
    {
        int choice;

        do
        {
            DisplayPlayerInfo();
            Console.WriteLine("");
            DisplayMenu();
            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                CreateGoal();
            }

            else if (choice == 2)
            {
                ListGoalDetails();
            }

            else if (choice == 3)
            {
                SaveGoals();
            }

            else if (choice == 4)
            {
                LoadGoals();
            }

            else if (choice == 5)
            {
                RecordEvent();
            }

            else
            {
                if (choice != 6)
                {
                    Console.WriteLine("That menu option doesn't exist.  Please enter one of the numbers from the menu.");
                }
            }
        } while (choice != 6); 
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
        Console.WriteLine($"You have completed {CalculateNumberOfGoalsCompleted()} goals.");
        Console.WriteLine(CalculateLevel());
    }

    public void ListGoalNames()
    {
        foreach (Goal goal in _goals)
        {
            int index = _goals.IndexOf(goal) + 1;
            Console.WriteLine($" {index}. {goal.GetName()}");
        }
    }

    public void ListGoalDetails()

    {
        Console.Clear();
        Console.WriteLine("The goals are:");

        foreach (Goal goal in _goals)
        {
            int index = _goals.IndexOf(goal) + 1;
            Console.WriteLine($" {index}. {goal.GetDetailsString()}");
        }
        Console.WriteLine("");
    }
   
    public void CreateGoal()
    {
        int userGoalChoice;
        string name;
        string description;
        int points;
        string success = "Success:  goal created!";
        DisplayGoalOptionsMenu();
        Console.Write("Which type of goal would you like to create? ");
        userGoalChoice = int.Parse(Console.ReadLine());

        if (userGoalChoice == 1)
        {
            Console.Write("What is the name of your goal? ");
            name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            description = Console.ReadLine();
            Console.Write("How many points will you be awarded for completing this goal? ");
            points = int.Parse(Console.ReadLine());
            SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
            _goals.Add(simpleGoal);
            Console.WriteLine(success);
        }

        else if (userGoalChoice == 2)
        {
            Console.Write("What is the name of your goal? ");
            name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            description = Console.ReadLine();
            Console.Write("How many points will you be awarded for completing this goal? ");
            points = int.Parse(Console.ReadLine());
            EternalGoal eternalGoal = new EternalGoal(name, description, points);
            _goals.Add(eternalGoal);
            Console.WriteLine(success);
        }

        else if (userGoalChoice == 3)
        {
            Console.Write("What is the name of your goal? ");
            name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            description = Console.ReadLine();
            Console.Write("How many points will you be awarded for completing this goal? ");
            points = int.Parse(Console.ReadLine());
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("How many bonus points will you be awarded for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(checklistGoal);
            Console.WriteLine(success);
        }

        else
        {
            Console.WriteLine("That goal type doesn't exist.  Please try again.");
        }
        Console.WriteLine("");
    }

    public void RecordEvent()
    {
        Console.WriteLine("The goals are:");
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        int userRecordEventChoice = int.Parse(Console.ReadLine());
        int userRecordEventChoiceIndex = userRecordEventChoice - 1;

        if (_goals[userRecordEventChoiceIndex].IsComplete())
        {
            Console.WriteLine("That goal has already been completed!  Please try again.");
        }

        else
        {
            _score += _goals[userRecordEventChoiceIndex].GetPoints();
            _goals[userRecordEventChoiceIndex].RecordEvent();

            if (_goals[userRecordEventChoiceIndex].IsComplete())
            {
                _score += _goals[userRecordEventChoiceIndex].GetBonusPoints();
            }
        }
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            //put _score on first line
            outputFile.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                string typeName = goal.GetType().ToString();
                outputFile.WriteLine($"{typeName}|{goal.GetStringRepresentation()}");
            }
        }
        Console.WriteLine("Success:  goals saved!");
        Console.WriteLine("");
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename of the goal file? ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        string score = lines[0];
        _score = int.Parse(score);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            if (parts.Length > 1)
            {
                string name = parts[1];
                string description = parts[2];
                string pointsToString = parts[3];
                int points = int.Parse(pointsToString);
                string amountCompletedString = parts[4];
                int amountCompleted = int.Parse(amountCompletedString);

                if (parts[0] == "SimpleGoal")
                {
                    SimpleGoal loadedsimpleGoal = new SimpleGoal(name, description, points);
                    loadedsimpleGoal.SetAmountCompleted(amountCompleted);
                    string isComplete = parts[5];
                    loadedsimpleGoal.SetIsComplete(bool.Parse(isComplete)); // Got help from a Bing search for converting string to boolean
                    _goals.Add(loadedsimpleGoal);
                }

                else if (parts[0] == "EternalGoal")
                {
                    EternalGoal loadedeternalGoal = new EternalGoal(name, description, points);
                    loadedeternalGoal.SetAmountCompleted(amountCompleted);
                    _goals.Add(loadedeternalGoal);
                }

                else if (parts[0] == "ChecklistGoal")
                {
                    string bonusString = parts[6];
                    int bonus = int.Parse(bonusString);
                    string targetString = parts[7];
                    int target = int.Parse(targetString);
                   
                    ChecklistGoal loadedchecklistGoal = new ChecklistGoal(name, description, points, target, bonus);
                    loadedchecklistGoal.SetAmountCompleted(amountCompleted);
                    _goals.Add(loadedchecklistGoal);
                }
            }
        }
        Console.WriteLine("Success:  goals loaded!");
        Console.WriteLine("");
    }

    public void GenerateMenu()
    {
        List<string> menu = new List<string>();
        menu.Add("Create New Goal");
        menu.Add("List Goals");
        menu.Add("Save Goals");
        menu.Add("Load Goals");
        menu.Add("Record Event");
        menu.Add("Quit");

        foreach (string item in menu)
        {
            int index = menu.IndexOf(item) + 1;
            Console.WriteLine($"  {index}. {item}");
        }
    }

    public void DisplayMenu()
    {
        Console.WriteLine("Menu Options:");
        GenerateMenu();
    }

    public void GenerateGoalOptionsMenu()
    {
        List<string> goalOptionsMenu = new List<string>();
        goalOptionsMenu.Add("Simple Goal (a goal that is completed once)");
        goalOptionsMenu.Add("Eternal Goal (a goal that repeats, but never finishes)");
        goalOptionsMenu.Add("Checklist Goal (a goal that is done a specified number of times to be completed)");

        foreach (string item in goalOptionsMenu)
        {
            int index = goalOptionsMenu.IndexOf(item) + 1;
            Console.WriteLine($"{index}. {item}");
        }
    }

    public void DisplayGoalOptionsMenu()
    {
        Console.WriteLine("The types of goals are:");
        GenerateGoalOptionsMenu();
    }
}