class Fraction

{
    private int _topnum;
    private int _bottomnum;

    public Fraction()
    {
        _topnum = 1;
        _bottomnum = 1;
        GetFraction();
    }

    public Fraction (int wholenum)
    {
        _topnum = wholenum;
        _bottomnum = 1;
        GetFraction();
    }

    public Fraction (int topnumber, int bottomnumber)
    {
        _topnum = topnumber;
        _bottomnum = bottomnumber;
        GetFraction();
    }

    public void GetTop()
    {
        Console.WriteLine($"Top Value: {_topnum}");
        GetFraction();
    }

    public void GetBottom()
    {
        Console.WriteLine($"Bottom Value: {_bottomnum}");
        GetFraction();
    }

    public void SetTop(int NewTop)
    {
        _topnum = NewTop;
        GetFraction();
    }

    public void SetBottom(int NewBottom)
    {
        _bottomnum = NewBottom;
        GetFraction();
    }

    public void GetFraction()
    {
        Console.WriteLine($"{_topnum}/{_bottomnum}");
    }
}