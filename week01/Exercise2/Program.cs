using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade percentage: ");
        string gradePercentageInText = Console.ReadLine();
        int gradePercentage = int.Parse(gradePercentageInText);

        // This is Core Requirement #3
        string letter = "";
        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }      

        // This is Stretch Challenge #1
        int lastDigit = gradePercentage % 10;
        string plusOrMinus = "";
        if (lastDigit >= 7)
        {
            plusOrMinus = "+";
        }
        else if (lastDigit < 3)
        {
            plusOrMinus = "-";
        }     

        // This is Stretch Challenge #2 and #3
        if ((letter == "A" && plusOrMinus == "+") || letter == "F")
        {
            Console.WriteLine($"Your letter grade is {letter}.");
        }
        else
        {
            Console.WriteLine($"Your letter grade is {letter}{plusOrMinus}.");
        }       

        // This is Core Requirement #2
        if (gradePercentage >= 70)
        {
            Console.Write("Congratulations, you passed!");
        }
        else
        {
            Console.Write("You didn't pass. You can do it next time!");
        }
    }
}