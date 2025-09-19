using System;
using System.Runtime.InteropServices;

namespace fraction;

public class Fractions
{
    private int _top;
    private int _bottom;

    public Fractions()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fractions(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fractions(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public int GetTop()
    {
        Console.WriteLine(_top);
        return _top;
    }

    public int GetBottom()
    {
        Console.WriteLine(_bottom);
        return _bottom;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        string top = _top.ToString();
        string bottom = _bottom.ToString();

        string fraction = top + "/" + bottom;

        return fraction;
    }

    public double GetDecimalValue()
    {
        double result;
        double top = _top;
        double bottom = _bottom;

        result = top / bottom;

        return result;
    }
}
