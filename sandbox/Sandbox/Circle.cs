class Circle
{
    public double _radius;

    public double GetRadius()
    {
        return _radius;
    }

    public void SetRadius(double radius)
    {
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
