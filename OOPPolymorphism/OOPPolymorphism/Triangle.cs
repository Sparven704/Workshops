public class Triangle : Geometry
{
    public double b { get; set; }
    public double h { get; set; }

    public double Area()
    {
        double area = (b * h)/2;
        return area;
    }

    public Triangle()
    {
        b = 10;
        h = 15;
    }
}