using System.Globalization;

class Activity
{

private string _activityName;
private string _description;
private int _seconds;

public Activity()
    {}

public void SetActivityName(string activity)
    {
        _activityName = activity;
    }

public string GetActivityName()
    {
        return _activityName;
    }

public void SetDescription(string description)
    {
        _description = description;
    }

public string GetDescription()
    {
        return _description;
    }

public void SetSeconds(int seconds)
    {
        _seconds = seconds;
    }

public int GetSeconds()
    {
        return _seconds;
    }

public void DisplayWelcome()
    {
        Console.WriteLine($"Welcome to the {_activityName} Activity!\n{_description}");
        Console.WriteLine("Requested Activity Duration in Seconds: ");
        int num1 = int.Parse(Console.ReadLine());
        SetSeconds(num1); 
        DisplayLoading("Prepare to begin", 1);
    }

public void DisplayEnding()
    {
        Console.WriteLine($"Thank you for participating in the {_activityName} Activity!\nWe hope you come again soon!");
    }

public void DisplayLoading(string message, int seconds)
    {
        DateTime CurrentTime = DateTime.Now;
        DateTime endTime = CurrentTime.AddSeconds(seconds);

        Console.WriteLine($"{message}..............");

        while (CurrentTime < endTime)
        {
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b");

            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b");

            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b");
            
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b");

            CurrentTime = DateTime.Now;
        }
    
    }



}