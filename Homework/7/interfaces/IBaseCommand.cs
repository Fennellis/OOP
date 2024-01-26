interface IBaseCommand
{
    ComplexNumber Sum(ComplexNumber first, ComplexNumber second, int accuracy = 5);
    ComplexNumber Sub(ComplexNumber first, ComplexNumber second, int accuracy = 5);
    ComplexNumber Mul(ComplexNumber first, ComplexNumber second, int accuracy = 5);
    ComplexNumber? Div(ComplexNumber first, ComplexNumber second, int accuracy = 5);
}