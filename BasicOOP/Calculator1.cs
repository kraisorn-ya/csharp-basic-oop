public struct Calculator
{
    private double _x;

    private double _y;
    public double x
    {
        get { return _x; }
        set { _x = value; }
    }

    public double y
    {
        get { return _y; }
        set { _y = value; }
    }
    public double Add()
    {
        return _x + _y;
    }
    public double Subtract()
    {
        return _x - _y;
    }
    public double Mutiply()
    {
        return _x * _y;
    }
    public double Divide()
    {
        return _x / _y;
    }
}