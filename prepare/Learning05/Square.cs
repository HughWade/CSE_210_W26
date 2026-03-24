class Square : Shape

{

private double _side;
public Square()
{}

public Square(string color1, double side) : base(color1)
{
        _side = side;
}

public override double GetArea()
{
    return _side * _side;
}

}