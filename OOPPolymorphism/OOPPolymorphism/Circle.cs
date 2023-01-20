public class Circle : Geometry
{
    public double Radius { get; set; }

    public double Area()
    {
        double area = Radius * Radius * 3.1415;
        return area;
    }
    public Circle()
    {
        Radius = 4;
    }
}
