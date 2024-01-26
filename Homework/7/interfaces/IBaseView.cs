interface IBaseView
{
    ConsoleKeyInfo Menu(ComplexNumber result, int accuracy);
    ComplexNumber Input();
    int? SetAccuracy();
}