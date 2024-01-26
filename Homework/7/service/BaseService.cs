class BaseService : IBaseCommand
{
    public BaseService()
    {}
    public ComplexNumber? Div(ComplexNumber first, ComplexNumber second, int accuracy)
    {
        if (second.RealPart == 0 && second.ImaginaryPart == 0)
            return null;
        double real = (first.RealPart * second.RealPart + first.ImaginaryPart * second.ImaginaryPart)
                    / (Math.Pow(second.RealPart, 2) + Math.Pow(second.ImaginaryPart, 2));
        double imaginary = (first.ImaginaryPart * second.RealPart - first.RealPart * second.ImaginaryPart)
                    / (Math.Pow(second.RealPart, 2) + Math.Pow(second.ImaginaryPart, 2));
        return new(Math.Round(real, accuracy),Math.Round(imaginary, accuracy));
    }

    public ComplexNumber Mul(ComplexNumber first, ComplexNumber second, int accuracy)
    {
        double real = first.RealPart * second.RealPart - (first.ImaginaryPart * second.ImaginaryPart);
        double imaginary = first.RealPart * second.ImaginaryPart + first.ImaginaryPart * second.RealPart;
        return new(Math.Round(real, accuracy),Math.Round(imaginary, accuracy));
    }

    public ComplexNumber Sub(ComplexNumber first, ComplexNumber second, int accuracy)
    {
        double real = first.RealPart - second.RealPart;
        double imaginary = first.ImaginaryPart - second.ImaginaryPart;
        return new(Math.Round(real, accuracy),Math.Round(imaginary, accuracy));
    }

    public ComplexNumber Sum(ComplexNumber first, ComplexNumber second, int accuracy)
    {
        double real = first.RealPart + second.RealPart;
        double imaginary = first.ImaginaryPart + second.ImaginaryPart;
        return new(Math.Round(real, accuracy),Math.Round(imaginary, accuracy));
    }
}