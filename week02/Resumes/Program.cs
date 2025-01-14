using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = 2022;
        job2._endYear = 2023;

        // Comment these two lines if the Display() methods from below work (they are a progress check)
        // Console.WriteLine(job1._company);
        // Console.WriteLine(job2._company);

        // Comment the following two lines if the myResume.Display() call below works (they are a progress check)
        // job1.Display();
        // job2.Display();

        Resume myResume = new Resume();
        myResume._name = "Allison Rose";
        
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // Comment the following line if it works (it's a progress check)
        // Console.WriteLine(myResume._jobs[0]._jobTitle);

        myResume.Display();
    }
}