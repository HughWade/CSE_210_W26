class Swimming : Activity
{

private int _lapNum;


public Swimming(string date, int length, int calories, int lapnum) : base(date, length, calories)
    {
        _lapNum = lapnum;
    }

public int GetNumberofLaps()
    {
        return _lapNum;
    }

public override double GetDistance() // in miles
{
    return _lapNum * 50 / 1000 *0.62;
}

public override double GetSpeed()
    {
        return GetDistance() / (GetLengthOfActivity()/60);
    }



public override string GetActivityType()
    {
        return "Swimming";
    }

}