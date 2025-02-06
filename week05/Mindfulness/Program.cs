// Check spionner timing
// Check line 31 note on ListingActivity()
// Check on demo video if ReflectingActivity() has user input like the one of the instructions says it does

// I attempted to Exceed Requirements by doing the following:
// 1.  Putting the menu into functions
// 2.  Creating another mindfulness activity called the Hymn Lines Activity

using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        int choice;
        do
        {
            DisplayMenu();
            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Console.Clear();
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.DisplayStartingMessage();
                breathingActivity.Run();
                breathingActivity.DisplayEndingMessage();
                Console.Clear();
            }
            else if (choice == 2)
            {
                Console.Clear();
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.DisplayStartingMessage();
                reflectingActivity.Run();
                reflectingActivity.DisplayEndingMessage();
                Console.Clear();
            }
            else if (choice == 3)
            {
                Console.Clear();
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.DisplayStartingMessage();
                listingActivity.Run();
                listingActivity.DisplayEndingMessage();
                Console.Clear();
            }
            else if (choice == 4)
            {
                Console.Clear();
                HymnLinesActivity hymnLinesActivity = new HymnLinesActivity();
                hymnLinesActivity.DisplayStartingMessage();
                hymnLinesActivity.Run();
                hymnLinesActivity.DisplayEndingMessage();
                Console.Clear();
            }
            else
            {
                if (choice != 5)
                {
                    Console.WriteLine("That menu option doesn't exist.  Please enter one of the numbers from the menu.");
                }
            }
            
        } while (choice != 5);
        
    }

    static void GenerateMenu()
        {
            List<string> menu = new List<string>();
            menu.Add("Start breathing activity");
            menu.Add("Start reflecting activity");
            menu.Add("Start listing activity");
            menu.Add("Start hymn lines activity");
            menu.Add("Quit");
            foreach (string item in menu)
            {
                int index = menu.IndexOf(item) + 1;
                Console.WriteLine($"{index}. {item}");
            }
        }
        
        static void DisplayMenu()
        {
            Console.WriteLine("Menu Options:");
            GenerateMenu();
        }
}