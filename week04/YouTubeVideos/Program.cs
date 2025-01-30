using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video();
        video1._title = "My First Video";
        video1._author = "John Smith";
        video1._length = 90;
        
        Comment video1Comment1 = new Comment();
        video1Comment1._name = "Mrs. Smith";
        video1Comment1._text = "My favorite video!";
        video1.AddComment(video1Comment1);
        
        Comment video1Comment2 = new Comment();
        video1Comment2._name = "Nancy Smith";
        video1Comment2._text = "So proud of my son, John!";
        video1.AddComment(video1Comment2);
        
        Comment video1Comment3 = new Comment();
        video1Comment3._name = "Teenager Timmy Smith";
        video1Comment3._text = "This video is mid.";
        video1.AddComment(video1Comment3);
        
        Video video2 = new Video();
        video2._title = "Sharp C#";
        video2._author = "BYU Pathway CSE 210";
        video2._length = 600;
        
        Comment video2Comment1 = new Comment();
        video2Comment1._name = "Sally Student";
        video2Comment1._text = "Love this 'Class'!";
        video2.AddComment(video2Comment1);
        
        Comment video2Comment2 = new Comment();
        video2Comment2._name = "Sam Student";
        video2Comment2._text = "What's the 'Object' of this video?";
        video2.AddComment(video2Comment2);
        
        Comment video2Comment3 = new Comment();
        video2Comment3._name = "Samantha Student";
        video2Comment3._text = "So abstract, love it!";
        video2.AddComment(video2Comment3);
        
        Video video3 = new Video();
        video3._title = "Superbowl Breakdown";
        video3._author = "ESPM";
        video3._length = 480;
        
        Comment video3Comment1 = new Comment();
        video3Comment1._name = "Andy Reid";
        video3Comment1._text = "Go Chiefs!";
        video3.AddComment(video3Comment1);
        
        Comment video3Comment2 = new Comment();
        video3Comment2._name = "Vince Papale";
        video3Comment2._text = "The Eagles are invincible!";
        video3.AddComment(video3Comment2);
        
        Comment video3Comment3 = new Comment();
        video3Comment3._name = "Mr. Obvious";
        video3Comment3._text = "The team with the most points at the end will win.";
        video3.AddComment(video3Comment3);
        
        Comment video3Comment4 = new Comment();
        video3Comment4._name = "Teenager Tinley";
        video3Comment4._text = "Who's playing? I just watch for the commercials and halftime show.";
        video3.AddComment(video3Comment4);
        
        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        
        foreach (Video video in videos)
        {
            video.Display();
            Console.WriteLine("");
        }
    }
}