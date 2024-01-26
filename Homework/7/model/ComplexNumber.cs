class ComplexNumber
{
    private double real;
    private double imaginary;
    public ComplexNumber(double real, double imaginary)
    {
        this.real = real;
        this.imaginary = imaginary;
    }
    public double RealPart{get {return real;}}
    public double ImaginaryPart{get {return imaginary;}}

    public override string ToString()
    {
        string temp = "";
        if (real != 0)
            temp += real;
        if (real != 0 && imaginary != 0)
        {
            if (imaginary > 0)
                temp += " + ";
            else
            {
                temp += " - ";
            }
        }
        if (imaginary != 0)
        {
            temp += imaginary switch
            {
                1 => "i",
                -1 => "-i",
                _ => $"{imaginary}i",
            };
        }
        if (temp == "")
            temp = "0";
        return temp;
    }
}