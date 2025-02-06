public class HymnLinesActivity : Activity
{
    private List<string> _hymnLines = new List<string>();
    
    public HymnLinesActivity()
    {
        _name = "Hymn Lines";
        _description = "This activity will provide comfort and peace by reflecting on the Savior through lines of sacred hymns.";
        _duration = 10;
        _hymnLines.Add("Then sings my soul, my Savior God to Thee\nHow great Thou art, how great Thou art"); // Bing search for lyrics
        _hymnLines.Add("Oh, it is wonderful that he should care for me\nEnough to die for me!\nOh, it is wonderful, wonderful to me!"); // Hymn #193
        _hymnLines.Add("I need thee, oh, I need thee; Ev'ry hour I need thee!\nOh, bless me now, my Savior; I come to thee!"); // Hymn #98
        _hymnLines.Add("Be still, my soul: the Lord is on thy side\nBe still, my soul: Thy best, thy heav'nly Friend"); // Hymn #124
    }
    
    public void Run()
    {
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
        Console.WriteLine("");
        Console.Clear();
        GetThoughtsFromUser();
        Console.Clear();
    }
    
    public string GetRandomHymnLines()
    {
        Random randomGenerator = new Random();
        int randomIndex = randomGenerator.Next(_hymnLines.Count);
        string lines = _hymnLines[randomIndex];
        return lines;
    }
    
    public void GetThoughtsFromUser()
    {
        string hymnLines = "";
        string response = "";
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        Console.WriteLine("Think about one specific challenge you're facing right now.");
        ShowSpinner(3);
        Console.WriteLine("");
        Console.WriteLine("Now take a deep breath and then ponder these lines...");
        Console.WriteLine("");
        hymnLines = GetRandomHymnLines();
        Console.WriteLine(hymnLines);
        ShowSpinner(3);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Do you feel any differently about the situation now?  Describe how.");
            ShowSpinner(3);
            Console.Write("> ");
            response = Console.ReadLine();
            Console.WriteLine($"These hymn lines:\n\n''{hymnLines}''\n\nprovided me peace and comfort, as follows:\n {response}");
            ShowCountDown(10);
        }
    }
}