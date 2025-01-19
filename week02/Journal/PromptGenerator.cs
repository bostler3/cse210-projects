public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public string GetRandomPrompt()
    {
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
        _prompts.Add("What was the most fun thing I did today?");
        _prompts.Add("What was the most stressful thing I encountered today?");
        _prompts.Add("What is one thing I learned from the scriptures today?");
        _prompts.Add("What did I spend money on today?");
        _prompts.Add("How did I serve God today?");
        Random randomGenerator = new Random();
        int index = randomGenerator.Next(_prompts.Count); // Got some help from a Bing search
        string randomPrompt = _prompts[index];  // Got some help from a Bing search
        return randomPrompt;
    }
}