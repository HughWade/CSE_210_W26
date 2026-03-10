class Fraction

{
    private double _topnum;
    private double _bottomnum;

    public Fraction()
    {
        _topnum = 1;
        _bottomnum = 1;
    }


    public Fraction (int wholenum)
    {
        _topnum = wholenum;
        _bottomnum = 1;
    }

    public Fraction (int topnumber, int bottomnumber)
    {
        _topnum = topnumber;
        _bottomnum = bottomnumber;
    }

    public double GetTop()
    {
        return _topnum;
    }

    public double GetBottom()
    {
        return _bottomnum;
    }

    public void SetTop(int NewTop)
    {
        _topnum = NewTop;
    }

    public void SetBottom(int NewBottom)
    {
        _bottomnum = NewBottom;
    }

    public string GetFractionString()
    {
        string stringtoreturn = $"{_topnum}/{_bottomnum}";
        return stringtoreturn;
    }

    public double GetDecimalValue()
    {
        double decimaltoreturn = _topnum / _bottomnum;
        return decimaltoreturn;
    }
}