/*
  Exceeding the Requirements:
  1. I think the assignment instructions indicate that randomly selecting from only those words that are not already
  hidden in HideRandomWords() in Scripture.cs is a "stretch challenge".  I believe this HideRandomWords method accomplishes that stretch challenge.

  2. I tried to enhance the user interface by adding a greeting, scripture options and number of words to hide input
*/

using System;

class Program
{
    static void Main(string[] args)
    {
      
      int verseSelection = 0;
      string response = "";
      int numberOfWordsToHide = 0;
      string book = "";
      int chapter = 0;
      int startVerse = 0;
      int endVerse = 0;
      string text = "";
      Reference reference = new Reference(book, chapter, startVerse, endVerse);

      Console.WriteLine("Welcome to the Scripture Memorizer Program!");
      Console.WriteLine("");
      Console.WriteLine("Enter '1' for an Old Testment scripture.");
      Console.WriteLine("Enter '2' for a New Testment scripture.");
      Console.WriteLine("Enter '3' for a Book of Mormon verse.");
      Console.WriteLine("Enter '4' for a Doctrine & Covenants scripture.");
      verseSelection = int.Parse(Console.ReadLine());

      Console.Write("How many words would you like to hide at a time? ");
      numberOfWordsToHide = int.Parse(Console.ReadLine());

      if (verseSelection == 1)
      {            
        book = "Proverbs";
        chapter = 3;
        startVerse = 5;
        endVerse = 6;
        text = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
      }

      else if (verseSelection == 2)
      {
        book = "John";
        chapter = 3;
        startVerse = 16;
        text = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
      }
      
      else if (verseSelection == 3)
      {
        book = "1 Nephi";
        chapter = 3;
        startVerse = 7;
        text = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.";
      }
      
      else if (verseSelection == 4)
      {
        book = "D&C";
        chapter = 82;
        startVerse = 10;
        text = "I, the Lord, am bound when ye do what I say; but when ye do not what I say, ye have no promise.";
      }

      else
      {
        Console.WriteLine("That selection is not available.  Please choose one of the options listed.");
      }
            
      
      if (verseSelection == 1)
      {
        reference = new Reference(book, chapter, startVerse, endVerse);
      }

      else
      {
        reference = new Reference(book, chapter, startVerse);
      }
      
      Scripture scripture = new Scripture(reference, text);
      Console.WriteLine(scripture.GetDisplayText());
      
      while (!scripture.IsCompletelyHidden())
      {
        Console.Write("Press enter to continue or type 'quit' to finish: ");
        response = Console.ReadLine();
        if (string.IsNullOrEmpty(response)) // Got help from a Bing search for how to react to user pressing "Enter" key
        {
          scripture.HideRandomWords(numberOfWordsToHide);
          Console.Clear();
          Console.WriteLine(scripture.GetDisplayText());
        }
        else if (response == "quit")
        {
          break;
        }
      }
    }
}