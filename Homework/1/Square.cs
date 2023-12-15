class Square : Rectangle
{
    public Square(double length)
    {
        base.length = length;
        area = length * length;
        perimetr = 4 * length;
    }

    public Square()
    {

    }

    public override string ToString()
    {
        return $"Length: {length:f2}\t Area: {area:f2}\t Perimetr: {perimetr:f2}";
    }

    public new double Length
    {
        get { return length;}
        set { length = value;
            area = length * length;
            perimetr = 4 * length;}
    }

    public new double Area
    {
        get { return area;}
        set { area = value;
            length = Math.Sqrt(area);
            perimetr = 4 * length;}
    }

    public new double Perimetr
    {
        get { return perimetr;}
        set { perimetr = value;
            length = perimetr / 4;
            area = length * length;}
    }
}