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
        Console.WriteLine();
        Console.WriteLine($"Welcome to the {_activityName} Activity!\n{_description}");
        Console.Write("Requested Activity Duration in Seconds: ");
        int num1 = int.Parse(Console.ReadLine());
        SetSeconds(num1); 
        DisplayLoading("Prepare to begin......", 5);
    }


public void SleepSeconds(double num)
    {
        Thread.Sleep(TimeSpan.FromSeconds(num));
    }

public void DisplayEnding()
    {
        Console.WriteLine("");
        DisplayLoading($"Great Job! You completed the {_activityName} Activity!",3);
        DisplayLoading($"You completed the {_activityName} activity for about {_seconds} seconds.", 3);
    }

public void DisplayLoading(string message, int seconds)
    {
        DateTime CurrentTime = DateTime.Now;
        DateTime endTime = CurrentTime.AddSeconds(seconds);

        Console.Write($"{message}");

        while (CurrentTime < endTime)
        {
            Console.Write("-");
            SleepSeconds(0.25);
            Console.Write("\b");

            Console.Write("\\");
            SleepSeconds(0.25);
            Console.Write("\b");

            Console.Write("|");
            SleepSeconds(0.25);
            Console.Write("\b");
            
            Console.Write("/");
            SleepSeconds(0.25);
            Console.Write("\b");

            CurrentTime = DateTime.Now;
        }
        Console.WriteLine();
    }

public void DisplayCountdown(string message, int seconds)
    {
        DateTime CurrentTime = DateTime.Now;
        DateTime endTime = CurrentTime.AddSeconds(seconds);

        Console.Write($"{message}");

        while (CurrentTime < endTime)
        {
            Console.Write($"{seconds}");
            SleepSeconds(1);
            seconds -= 1;
            Console.Write("\b");
            CurrentTime = DateTime.Now;
            
        }
        Console.WriteLine();
    }


}