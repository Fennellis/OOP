class Figure
{
    protected double area;
    protected double perimetr;

    public Figure(double area, double perimetr)
    {
        this.area = area;
        this.perimetr = perimetr;
    }

    public Figure()
    {
        
    }

    public override string ToString()
    {
        return $"Area: {area:f2}\t Perimetr: {perimetr:f2}";
    }

    public double Area
    {
        get { return area;}
        set { area = value;}
    }

    public double Perimetr
    {
        get { return perimetr;}
        set { perimetr = value;}
    }
}