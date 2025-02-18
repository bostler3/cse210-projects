using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        Running running1 = new Running("03 Nov 2022", "Running", 30, 3);
        Cycling cycling1 = new Cycling("03 Nov 2022", "Cycling", 30, 8);
        Swimming swimming1 = new Swimming("03 Nov 2022", "Swimming", 30, 30);
        activities.Add(running1);
        activities.Add(cycling1);
        activities.Add(swimming1);
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}