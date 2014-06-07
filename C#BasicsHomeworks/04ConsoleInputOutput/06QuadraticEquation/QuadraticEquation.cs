using System;
//Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("This problem will solve a quadratic equation ax2 + bx + c = 0");
        Console.Write("Please enter the coefficient a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Please enter the coefficient b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Please enter the coefficient c: ");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("The equation is: {0}{3}2 + {1}{3} + {2} = 0",a,b,c,"x");
        double d = Math.Pow(b, 2) - 4 * a * c;
        Console.WriteLine("D=" +d);
        if(d<0)
        {
            Console.WriteLine("There are no real roots!");
        }
        else if(d==0)
        {
            double x = ((-b + Math.Sqrt(d)) / (2 * a));
            Console.WriteLine("x1=x2="+x);
        }
        else if(d>0)
        {
            double x1 = ((-b - Math.Sqrt(d)) / (2 * a));
            double x2 = ((-b + Math.Sqrt(d)) / (2 * a));
            Console.WriteLine("x1 ="+x1);
            Console.WriteLine("x2 ="+x2);
        }
    }
}