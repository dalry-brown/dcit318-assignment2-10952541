using System;

public class Program
{
    public static void Main(string[] args)
    {
        Circle myCircle = new Circle(5.0);
        Rectangle myRectangle = new Rectangle(4.0, 6.0);
        
        Console.WriteLine("Area of the circle: " + myCircle.GetArea());       // Outputs: Area of the circle: 78.53981633974483
        Console.WriteLine("Area of the rectangle: " + myRectangle.GetArea()); // Outputs: Area of the rectangle: 24.0
    }
}
