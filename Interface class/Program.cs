using System;

public class Program
{
    public static void Main(string[] args)
    {
        IMovable myCar = new Car();
        IMovable myBicycle = new Bicycle();
        
        myCar.Move();       // Outputs: Car is moving
        myBicycle.Move();   // Outputs: Bicycle is moving
    }
}
