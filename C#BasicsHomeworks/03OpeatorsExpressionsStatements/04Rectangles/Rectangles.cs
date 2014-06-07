using System;
//Write an expression that calculates rectangle’s perimeter and area by given width and height.
class Rectangles
{
    static void Main()
    {
        Console.WriteLine("This program calculates rectangle’s perimeter and area by given width and height!");
        Console.Write("Please enter width: ");
        double width = double.Parse(Console.ReadLine());
        Console.WriteLine("You have entered :" +width);
        Console.Write("Please enter height: ");
        double height = double.Parse(Console.ReadLine());
        Console.WriteLine("You have entered a width of "+width+" and height of "+height+"!");
        Console.WriteLine("Perimeter: "+((2*width)+(2*height)) + "\n" + "Area: " + (width*height));
    }
}