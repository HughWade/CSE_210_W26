class Rectangle : Shape
{

private double _sideone;
private double _sidetwo;

public Rectangle()
{}

public Rectangle(string color, double side1, double side2) : base(color)
    {
        _sideone = side1; _sidetwo = side2;
    }

public override double GetArea()
{
    return _sideone * _sidetwo;
}

}