class Circle : Figure
{
    private double radius;
    private const double PI = 3.14;

    public Circle(double radius)
    {
        this.radius = radius;
        area = PI * Math.Pow(radius, 2);
        perimetr = 2 * PI * radius;
    }
    public Circle()
    {

    }

    public override string ToString()
    {
        return $"Radius: {radius:f2}\t Area: {area:f2}\t Perimetr: {perimetr:f2}";
    }

    public double Radius
    {
        get { return radius;}
        set { radius = value;
            area = PI * Math.Pow(radius, 2);
            perimetr = 2 * PI * radius;}
    }

    public new double Area
    {
        get {return area;}
        set {area = value;
            radius = Math.Sqrt(area / PI);
            perimetr = 2 * PI * radius;}
    }

    public new double Perimetr
    {
        get {return perimetr;}
        set {perimetr = value;
            radius = perimetr / (2 * PI);
            area = PI * Math.Pow(radius, 2);}
    }
}