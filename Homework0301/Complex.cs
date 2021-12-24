class Complex
{
    public int a, b;
    public Complex (int re, int im)
    {
        this.a = re;
        this.b = im;
    }  
    public override string ToString()
    {
        string s;
        if (b<0) s = $"{a} - {-b}i";
        else if (a<0) s = $"-{-a} + {b}i";
        else if (a<0 && b<0) s = $"-{-a} - {-b}i";
        else s = $"{a} + {b}i";
        return s;
    }
    public Complex Sum(Complex z)
    {
        Complex result;
        result = new(this.a + z.a, this.b + z.b);
        return result;
    }
    public Complex Sub(Complex z)
    {
        Complex result2;
        result2 = new(this.a-z.a, this.b-z.b);
        return result2;
    }
        public Complex Prod(Complex z1, Complex z2)
    {
        Complex result3;
        result3 = new(z1.a*z2.a-z1.b*z2.b, z1.b*z2.a+z1.a*z2.b);
        return result3;
    }
}