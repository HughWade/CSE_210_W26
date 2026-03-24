class Square : Shape

{

private int _side;
public Square()
{}

public Square(string color1, int side) : base(color1)
{
        _side = side;
}

public override double GetArea()
{
    return _side * _side;
}

}