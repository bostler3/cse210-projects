using System;

class Program
{
    static void Main(string[] args)
    {
        // Core Requirements #1 and 2
        /*
        Console.Write("What is the magic number? ");
        string answer = Console.ReadLine();
        int magicNumber = int.Parse(answer);
        int guess;
        do
        {
            Console.Write("What is your guess? ");
            string guessAnswer = Console.ReadLine();
            guess = int.Parse(guessAnswer);         

            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.Write("You guessed it!");
            }
        } while (guess != magicNumber);
        */
        // Core Requirement #3 and Stretch Challenges #1 and 2
        Random randomGenerator = new Random();      
        string continueResponse = "yes";
        while (continueResponse == "yes")
        {
            int magicNumber = randomGenerator.Next(0,100);
            // Uncomment the following line to print the random number for faster testing
            // Console.WriteLine(magicNumber);
            int guess;
            int count = 0;
            do
            {
                Console.Write("What is your guess? ");
                string guessAnswer = Console.ReadLine();
                guess = int.Parse(guessAnswer);
                count += 1;
                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"You guessed it in {count} tries!");
                }
            } while (guess != magicNumber);
            Console.Write("Do you want to play again (yes/no)? ");
            continueResponse = Console.ReadLine();
        }
    }
}