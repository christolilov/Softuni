using System;
//Write a program that enters 3 real numbers and prints them sorted in descending order. 
//Use nested if statements. Don’t use arrays and the built-in sorting functionality.
class SortThree
{
    static void Main()
    {
        Console.WriteLine("This program will find the biggest of three given numbers and sort them in descending order!");
        Console.Write("Enter number a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter number b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter number c: ");
        double c = double.Parse(Console.ReadLine());
        if (a > b && a > c)
        {
            if(b>c)
            {
                Console.WriteLine("Numbers in descending order: {0} {1} {2}",a,b,c);
            }
            else if (c>b)
            {
                Console.WriteLine("Numbers in descending order: {0} {1} {2}", a, c, b);
            }
            else if (c==b)
            {
                Console.WriteLine("Numbers in descending order: {0} {1} {2}", a, b, c);
            }
        }
        else if (b > c && b > a)
        {
            if (a > c)
            {
                Console.WriteLine("Numbers in descending order: {0} {1} {2}", b, a, c);
            }
            else if (c > a)
            {
                Console.WriteLine("Numbers in descending order: {0} {1} {2}", b, c, a);
            }
            else if (c == b)
            {
                Console.WriteLine("Numbers in descending order: {0} {1} {2}", b, a, c);
            }
        }
        else if (c > b && c > a)
        {
            if (b > a)
            {
                Console.WriteLine("Numbers in descending order: {0} {1} {2}", c, b, a);
            }
            else if (a > b)
            {
                Console.WriteLine("Numbers in descending order: {0} {1} {2}", c, a, b);
            }
            else if (a == b)
            {
                Console.WriteLine("Numbers in descending order: {0} {1} {2}", c, a, b);
            }
        }
        else if(a==b && b==c)
        {
            Console.WriteLine("The numbers are equal: {0} {1} {2}", a, b, c);
        }
    }
}