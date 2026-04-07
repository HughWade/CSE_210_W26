class Running : Activity
{

private double _distance;


public Running(string date, int length, int calories, double distance) : base(date, length, calories)
    {
        _distance = distance;
    }

public override double GetDistance()
    {
        return _distance;
    }

public override double GetSpeed()
    {
        return _distance / (GetLengthOfActivity()/60);
    }



public override string GetActivityType()
    {
        return "Running";
    }

}