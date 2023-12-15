class Rectangle : Figure
{
    protected double length;
    private double width;
    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
        base.area = length * width;
        base.perimetr = 2 * (length + width);
    }

    public Rectangle()
    {

    }

    public override string ToString()
    {
        return $"Length: {length:f2}\t Width: {width:f2}\t Area: {area:f2}\t Perimetr: {perimetr:f2}";
    }

    public double Length
    {
        get { return length;}
        set { length = value;
            area = length * width;
            perimetr = 2 * (length + width);}
    }

    public double Width
    {
        get { return width;}
        set { width = value;
            area = length * width;
            perimetr = 2 * (length + width);}
    }


    public new double Area
    {
        get { return area;}
    }

    public new double Perimetr
    {
        get { return perimetr;}
    }
}