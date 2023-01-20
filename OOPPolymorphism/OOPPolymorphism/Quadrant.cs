public class Quadrant : Geometry
{
    public double a { get; set; }
    public double b { get; set; }
    public double Area()
    {
        double area = a * b;
        return area;
    }
    public Quadrant()
    {
        a = 5;

        b = 5;
    }
}
