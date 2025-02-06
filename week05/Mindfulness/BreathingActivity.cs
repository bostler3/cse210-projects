public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
        _duration = 10;
    }
    
    public void Run()
    {
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("");
            Console.Write("Breath in...");
            ShowCountDown(5);
            Console.WriteLine("");
            
            Console.WriteLine("");
            Console.Write("Breath out...");
            ShowCountDown(5);
            Console.WriteLine("");
        }
    }
}