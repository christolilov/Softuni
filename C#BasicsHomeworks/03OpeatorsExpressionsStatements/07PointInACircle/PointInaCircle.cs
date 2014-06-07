using System;
//Write an expression that checks if given point (x,  y) is inside a circle K({0, 0}, 2).
class PointInACircle
{
    static void Main()
    {
        Console.WriteLine("This program will check if given point (x,  y) is inside a circle K({0, 0}, 2)!");
        Console.WriteLine("Enter value for x:");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter value for y:");
        double y = double.Parse(Console.ReadLine());
        Console.WriteLine((((x * x) + (y * y)) <= 2 * 2) ? ("The point is in the circle.") : ("The point is out of the circle."));
    }
}