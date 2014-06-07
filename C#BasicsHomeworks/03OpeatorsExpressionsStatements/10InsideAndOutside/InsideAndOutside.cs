using System;
//Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle
//R(top=1, left=-1, width=6, height=2)
class InsideAndOtside
{
    static void Main()
    {
        Console.Write("Enter x: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter y: ");
        double y = double.Parse(Console.ReadLine());
        double r = 1.5;
        bool isInCircle = r * r >= (x - 1) * (x - 1) + (y - 1) * (y - 1);//Checks if the point is in the circle!
        bool isInRectangle = (x >= -1) && (x <= 5) && (y >= -1) && (y <= 1);//Checks if the point is in the rectangle!
        Console.WriteLine("Is the point in the circle and outside the rectangle?");
        Console.WriteLine( isInCircle && !isInRectangle ? "Yes" : "No" );
    }
}