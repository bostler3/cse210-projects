using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        int choice = 0;
        Journal myJournal = new Journal();
        while (choice != 5)
        {
            DisplayMenu();
            Console.Write("What would you like to do? ");
            choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Entry entry = new Entry();
                DateTime theCurrentDate = DateTime.Now;
                entry._date = theCurrentDate.ToShortDateString();
                PromptGenerator promptGenerator = new PromptGenerator();
                string prompt = promptGenerator.GetRandomPrompt();
                entry._promptText = prompt;
                Console.WriteLine(prompt);
                Console.Write("> ");
                entry._entryText = Console.ReadLine();
                myJournal.AddEntry(entry);
            }
            else if (choice == 2)
            {
                myJournal.DisplayAll();
            }
            else if (choice == 3)
            {
                Console.Write("What is the file name? ");
                string file = Console.ReadLine();
                myJournal.LoadFromFile(file);
                Console.WriteLine("Success:  journal loaded!");
            }
            else if (choice == 4)
            {
                Console.Write("What is the file name? ");
                string file = Console.ReadLine();
                myJournal.SaveToFile(file);
                Console.WriteLine("Success:  journal saved!");
            }
            // This is an attempt to Exceed the Requirements
            else if (choice == 6)
            {
                myJournal.GetRandomMemory();
            }
            // Tried to Exceed the Requirements by handling all other user input here
            else
            {
                if (choice != 5)
                {
                    Console.WriteLine("Invalid input. Please enter one of the numbers from the menu.");
                }
            }
        }
    }             
    
    // This is an attempt to Exceed the Requirements
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Journal Program!");
    }              
    
    // This is an attempt to Exceed the Requirements
    static void DisplayMenu()
    {
        Console.WriteLine("Please select one of the following choices: ");
        GenerateMenu();
    }              
    
    // This is an attempt to Exceed the Requirements.  I thought it would be good to have in case the menu needed to expand.
    static void GenerateMenu()
    {
        List<string> menu = new List<string>();
        menu.Add("Write");
        menu.Add("Display");
        menu.Add("Load");
        menu.Add("Save");
        menu.Add("Quit");
        menu.Add("Remember a Random Entry!");  // This is an attempt to Exceed the Requirements
        foreach (string item in menu)
        {
            int index = menu.IndexOf(item) + 1;
            Console.WriteLine($"{index}. {item}");
        }
    }
}