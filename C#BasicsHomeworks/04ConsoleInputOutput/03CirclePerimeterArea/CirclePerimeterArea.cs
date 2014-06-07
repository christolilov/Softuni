using System;
//Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point. 
    class CirclePerimeterArea
    {
        static void Main()
        {
            
            Console.WriteLine("This program will calculate a circle's perimeter and area by a given radius!");
            Console.Write("Please enter radius: ");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine();
            double perimeter = 2*Math.PI*radius;
            double area = Math.PI*Math.Pow(radius, 2);
            Console.WriteLine("Perimeter is: {0:0.00}",perimeter);
            Console.WriteLine("Area is: {0:0.00}", area);
        }
    }