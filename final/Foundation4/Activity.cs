using System.Runtime.InteropServices;

class Activity
{

private string _date;
private int _lengthOfActivity;

public Activity(string date1, int length)
    {
        _date = date1; _lengthOfActivity = length;
    }

public string GetDate()
    {
        return _date;
    }

public int GetLengthOfActivity()
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
        return $"{GetDate()} {GetActivityType()} ({GetLengthOfActivity()} min) - Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }

}