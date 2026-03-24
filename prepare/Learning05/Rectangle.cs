class Rectangle : Shape
{

private int _sideone;
private int _sidetwo;

public Rectangle()
{}

public Rectangle(string color, int side1, int side2) : base(color)
    {
        _sideone = side1; _sidetwo = side2;
    }

public override double GetArea()
{
    return _sideone * _sidetwo;
}

}