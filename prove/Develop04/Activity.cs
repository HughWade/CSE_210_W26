class Activity
{

private string _activityName;
private string _description;
private int _seconds;

public Activity(string name, string description)
    {
        _activityName = name;
        _description = description;
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
        }
    
    }



}