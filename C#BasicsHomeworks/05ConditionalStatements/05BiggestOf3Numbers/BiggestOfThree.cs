using System;
//Write a program that finds the biggest of three numbers. 
class BiggestOfThree
{
    static void Main()
    {
        Console.WriteLine("This program will find the biggest of three given numbers!");
        Console.Write("Enter number a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter number b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter number c: ");
        double c = double.Parse(Console.ReadLine());
        if(a>b && a>c)
        {
            Console.WriteLine("The biggest number is {0}",a);
        }
        else if(b>c && b>a)
        {
            Console.WriteLine("The biggest number is {0}", b);
        }
        else if (c > b && c > a)
        {
            Console.WriteLine("The biggest number is {0}", c);
        }
        else if (a==b && b==c)
        {
            Console.WriteLine("The numbers are equal!");
        }
    }
}