






using System;
using System.Formats.Asn1;

Circle circle1 = new Circle(5);
Circle circle2 = new Circle(6);

Console.WriteLine("Area of circle with radius of " + circle1.radius + ": " + circle1.getArea(circle1.radius));
Console.WriteLine("Area of circle with radius of " + circle2.radius + ": " + circle2.getArea(circle2.radius));


public class Circle
{
    public double area;
    public double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }
    public double getArea(double radius)
    {
        area = Math.Pow(3.14159 * radius, 2);
        return area;
    }

}
