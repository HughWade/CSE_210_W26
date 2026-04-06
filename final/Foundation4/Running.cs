class Running : Activity
{

private int _distance;


public Running(string date, int length, int distance) : base(date, length)
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