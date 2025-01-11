using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int answer = 1;
        float sum = 0;
        double average;
        int max;
        List<int> numbers = new List<int>();
        // The next two lines are for Stretch Challenge #1
        int minMax;
        List<int> minNumbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (answer != 0)
        {
            Console.Write("Enter number: ");
            answer = int.Parse(Console.ReadLine());
            if (answer != 0)
            {
                numbers.Add(answer);
            }
        }
        // Uncomment the following code to see the contents of the list
        // Console.WriteLine(string.Join(", ", numbers)); // Found this solution using a Bing search
        foreach (int number in numbers)
        {
            sum += number;
            // This is for Stretch Challenge #1
            if (number > 0)
            {
                minNumbers.Add(number);
            }
        }
        Console.WriteLine($"The sum is: {sum}");
        average = numbers.Average(); // Using the discovery of the Max() function below, I found out there is an Average() function!
        Console.WriteLine($"The average is: {average}");
        max = numbers.Max(); // Found this Max() function on a StackOverflow post
        Console.WriteLine($"The largest number is: {max}");
        // This is for Stretch Challenge #1
        minMax = minNumbers.Min();
        Console.WriteLine($"The smallest positive number is: {minMax}");
        
        // This is for Stretch Challenge #2
        numbers.Sort(); // Found this function on a StackOverflow post
        Console.WriteLine("The sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}