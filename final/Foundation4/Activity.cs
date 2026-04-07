using System.Runtime.InteropServices;

class Activity
{

private string _date;
private int _lengthOfActivity;
private int _caloriesBurned;

public Activity(string date1, int length, int calories)
    {
        _date = date1; _lengthOfActivity = length; _caloriesBurned = calories;
    }

public int GetCaloriesBurned()
    {
        return _caloriesBurned;
    }

public string GetDate()
    {
        return _date;
    }

public double GetLengthOfActivity()
    {
        return _lengthOfActivity; // this is in minutes
    }

public virtual double GetDistance() // in miles
{
    return 0;
}

public virtual double GetSpeed() // in miles per hour for all classes
    {
        return 0;
    }

public double GetPace() // in minutes per mile
    {
        return GetLengthOfActivity() / GetDistance();
    }


public virtual string GetActivityType()
    {
        return "Activity";
    }

public string GetSummary()
    {
        return $"{GetDate()} {GetActivityType()} ({GetLengthOfActivity()} min) - Distance {Math.Round(GetDistance(), 2)} miles, Speed {Math.Round(GetSpeed(), 2)} mph, Pace: {Math.Round(GetPace(), 2)} min per mile, Calories Burned: {GetCaloriesBurned()}";
    }

}