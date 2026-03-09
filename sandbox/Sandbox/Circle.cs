class Circle
{
    private double _radius;

    
    public Circle ()
    {
        _radius = 0;
    }

    public Circle (double radius)
    {
        _radius = radius;
    }
    
    
    public double GetRadius()
    {
        return _radius;
    }

    public void SetRadius(double radius)
    {
        if (radius < 0)
        {
            Console.WriteLine("Invalid radius input, less than zero.");
        }
        
        else
        _radius = radius;
    }

    public double GetArea()
    {
        return _radius * _radius * Math.PI;
    }

    public double GetDiameter()
    {
        return 2 * _radius;
    }

    public double GetCircumference()
    {
    return 2 * Math.PI * _radius;
    }
}
