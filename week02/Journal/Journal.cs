using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    Entry randomMemory = new Entry();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    
    public void DisplayAll()
    {
        foreach (Entry item in _entries)
        {
            item.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry item in _entries)
            {
                outputFile.WriteLine($"{item._date}~~{item._promptText}~~{item._entryText}");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        // Used the video tutorial from the assignment instructions for assistance in writing this code
        string[] lines = System.IO.File.ReadAllLines(file);
        
        foreach (string line in lines)
        {
            string[] parts = line.Split("~~");
            Entry entry = new Entry();
            entry._date = parts[0];
            entry._promptText = parts[1];
            entry._entryText = parts[2];
            _entries.Add(entry);
        }
    }

    /*
        This is an attempt to Exceed the Requirements.  I thought a way to perhaps encourage journal writing is to allow users to remember a random past entry.
        This is kind of like the "On this day" feature on iPhone or OneDrive pictures. Perhaps the user might think, 
        "Oh, I remember that journal entry. I'm glad I recorded that and am keeping a journal!"
    */ 
    public void GetRandomMemory()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries exist in the journal. Select '1' to record some to remember for later!");
        }

        else
        {
            Random randomGenerator = new Random();
            int index = randomGenerator.Next(_entries.Count);
            randomMemory = _entries[index];
            randomMemory.Display();
        }
        
    }
}