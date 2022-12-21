using System;

internal class ComplexNumber
{
    private double re;
    private double im;
    private double zAbc;
    private double arg;
    
    public ComplexNumber(double re = 0, double im = 0)
    {
        this.re = re;
        this.im = im;
    }
    public double Re
    {
        get => re;
        set
        {
            re = value;
        }
    }
    public double Im
    {
        get => im;
        set
        {
            im = value;
        }
    }
    public double AbcZ
    {
        get
        {
            return zAbc;
        }
        set
        {
            zAbc = value;
        }
    }
    public double Arg
    {
        get
        {
            return arg;
        }
        set
        {
            arg = value;
        }
    }

    public double Mod
    {
        get { return zAbc; }
        set
        {
            zAbc = value;
        }
    }

    public double GetMod() => zAbc;
    public double GetArg() => arg;

    static public ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
    {
        return new ComplexNumber(c1.re + c2.re, c1.im + c2.im);
    }
    static public ComplexNumber operator -(ComplexNumber c1, ComplexNumber c2)
    {
        return new ComplexNumber(c1.re - c2.re, c1.im - c2.im);
    }
    static public ComplexNumber operator *(ComplexNumber c1, ComplexNumber c2)
    {
        return new ComplexNumber(c1.re * c2.re + c1.im * c2.im * -1, c1.re * c2.im + c1.im * c2.re);
    }
    static public ComplexNumber operator /(ComplexNumber c1, ComplexNumber c2)
    {
        var a = c1 * new ComplexNumber(c2.re, c2.im * -1);
        double t = c2.re * c2.re + c2.im * c2.im;
        return new ComplexNumber(a.re / t, a.im / t);
    }

    public override string ToString()
    {
        if (re != 0 && im != 0 && im < 0)
        {
            return $"{re} {im}i";
        }
        else if (re != 0 && im != 0 && im > -1)
        {
            return $"{re} +{im}i";
        }
        else if (re == 0 && im != 0)
        {
            return $"{im}i";
        }
        else if (im == 0 && re != 0)
        {
            return $"{re}";
        }
        else
        {
            return string.Empty;
        }
    }

}