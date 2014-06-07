using System;
//Write an expression that calculates trapezoid's area by given sides a and b and height h.
class Trapezoid
{
    static void Main()
    {
        Console.WriteLine("This program will calculate a trapezoid's area by given sides a and b and height h!");
        Console.Write("Please enter side a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Please enter side b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Please enter height: ");
        double h = double.Parse(Console.ReadLine());
        double area = ((a + b) / 2) * h;
        Console.WriteLine("The area of the trapezoid is: " + area);
    }
}
