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
        DisplayLoading($"Welcome to the {_activityName} Activity!\n{_description}",10);
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
        DisplayLoading($"You participated in the {_activityName} activity for about {_seconds} seconds.", 3);

        if (_activityName == "Breathing")
        {
           Console.WriteLine();
           Console.WriteLine("Here's a picture representing the activity\nyou just particiapted in!");
           SleepSeconds(2);
           Console.WriteLine();
           Console.WriteLine(" ------");
           Console.WriteLine("|      \\");
           Console.WriteLine("|     O");
           Console.WriteLine("|     _\\  -------");
           Console.WriteLine(" |____C-------   -------");
           Console.WriteLine("             -------");
           Console.WriteLine();
        
        }

        if (_activityName == "Reflection")
        {
        Console.WriteLine();
        Console.WriteLine("Here's a picture representing the activity\nyou just particiapted in!");
        SleepSeconds(2);
        Console.WriteLine();
        Console.WriteLine("            ____");
        Console.WriteLine("          (     )");
        Console.WriteLine("        (        )");
        Console.WriteLine("       ( THOUGHTS )");
        Console.WriteLine("       (         )");
        Console.WriteLine("         (______) ");
        Console.WriteLine("        _");
        Console.WriteLine("       |_|     ");
        Console.WriteLine("      O  ");
        Console.WriteLine("    O");
        Console.WriteLine();
        }

        if (_activityName == "Listing")
        {
            Console.WriteLine();
            Console.WriteLine("Here's a picture representing the activity\nyou just particiapted in!");
            SleepSeconds(2);
            Console.WriteLine();
            Console.WriteLine(" ___________");
            Console.WriteLine(".|          | ");
            Console.WriteLine(".|  NOTES   |");
            Console.WriteLine(".|          |   A");
            Console.WriteLine(".|          |  | |");
            Console.WriteLine(".|          |  | |");
            Console.WriteLine(".|          |  |_|");
            Console.WriteLine(".|__________|  |_|");
            Console.WriteLine();





        }

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