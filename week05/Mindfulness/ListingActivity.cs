public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();
    
    public ListingActivity()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _duration = 10;
        _count = 0;
        _prompts.Add(" --- Who are people that you appreciate? ---");
        _prompts.Add(" --- What are your personal strengths? ---");
        _prompts.Add(" --- Who are people that you have helped this week? ---");
        _prompts.Add(" --- When have you felt the Holy Ghost this month? ---");
        _prompts.Add(" --- Who are some of your personal heroes? ---");
    }
    
    public void Run()
    {
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
        Console.WriteLine("");
        Console.WriteLine("List as many responses as you can to the following prompt:");
        GetRandomPrompt();
        Console.Write("You may begin in...");
        ShowCountDown(7);
        Console.WriteLine("");
        List<string> userList = GetListFromUser();
        _count = userList.Count;
        Console.WriteLine($"You listed {_count} items!");
    }
    
    public void GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int randomIndex = randomGenerator.Next(_prompts.Count);
        Console.WriteLine(_prompts[randomIndex]);
    }
    
    public List<string> GetListFromUser()
    {
        List<string> listFromUser = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            listFromUser.Add(item);
        }
        return listFromUser;
    }
}