using System.Runtime.InteropServices;

class Cycling : Activity
{

private int _speed; // should be in miles per hour


public Cycling(string date, int length, int speed) : base(date, length)
    {
        _speed = speed;
    }

public override double GetSpeed()
    {
        return _speed;
    }

public override double GetDistance()
    {
        return _speed * (GetLengthOfActivity()/60);
    }

public override string GetActivityType()
    {
        return "Cycling";
    }

}