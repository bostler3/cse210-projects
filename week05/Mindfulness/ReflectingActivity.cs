public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();
    
    public ReflectingActivity()
    {
        _name = "Reflection";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience.  This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _duration = 10;
        _prompts.Add(" --- Think of a time when you stood up for someone else. ---");
        _prompts.Add(" --- Think of a time when you did something really difficult. ---");
        _prompts.Add(" --- Think of a time when you helped someone in need. ---");
        _prompts.Add(" --- Think of a time when you did something truly selfless. ---");
        _questions.Add("> Why was this experience meaningful to you?");
        _questions.Add("> Have you ever done anything like this before?");
        _questions.Add("> How did you get started?");
        _questions.Add("> How did you feel when it was complete?");
        _questions.Add("> What made this time different than other times when you were not as successful?");
        _questions.Add("> What is your favorite thing about this experience?");
        _questions.Add("> What could you learn from this experience that applies to other situations?");
        _questions.Add("> What did you learn about yourself through this experience?");
        _questions.Add("> How can you keep this experience in mind in the future?");
    }
    
    public void Run()
    {
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
        Console.WriteLine("");
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine("");
        DisplayPrompt();
        Console.WriteLine("");
        Console.WriteLine("When you have something in mind, please enter to continue.");
        Console.ReadLine(); // Got help for this line from a Bing search to know how to receive "Enter" input from user
        Console.WriteLine("Now ponder each of the following questions as they related to this experience.");
        Console.Write("You may begin in...");
        ShowCountDown(7);
        Console.Clear();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            DisplayQuestions();
            ShowSpinner(3);
            Console.WriteLine("");
        }
    }
    
    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int randomIndex = randomGenerator.Next(_prompts.Count);
        string prompt = _prompts[randomIndex];
        return prompt;
    }
    
    public string GetRandomQuestion()
    {
        Random randomGenerator = new Random();
        int randomIndex = randomGenerator.Next(_questions.Count);
        string question = _questions[randomIndex];
        return question;
    }
    
    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
    }
    
    public void DisplayQuestions()
    {
        Console.Write(GetRandomQuestion());
    }
}