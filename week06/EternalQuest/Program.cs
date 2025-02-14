// Exceeding Requirements
// Created levels the user can achieve by accomplishing a certain number of goals and incorporated them into the user interface
// Added a short description for each goal type to try to enhance the user interface by providing a "definition" of each goal for the user in case he/she doesn't know what they mean
// Added "animated"/flashing message to the user for completing a task (trying to show excitement for achievement!)
// Added an additional message to the user if they achieved the bonus points on a checklist goal
// Added user interface messages for when create goal, save goals and load goals are successful
// Added a check to RecordEvent() in the GoalManager() class to see if a goal is complete to avoid allowing points to be added for a goal that's already been completed

using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}