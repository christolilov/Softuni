using System;
//Write a program that finds the biggest of five numbers by using only five if statements. 
class BiggestOfFive
{
    static void Main()
    {
        Console.WriteLine("This program will find the biggest of five given numbers!");
        Console.Write("Enter number a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter number b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter number c: ");
        double c = double.Parse(Console.ReadLine());
        Console.Write("Enter number d: ");
        double d = double.Parse(Console.ReadLine());
        Console.Write("Enter number e: ");
        double e = double.Parse(Console.ReadLine());
        if(a > b && a > c && a > d && a > e) //1
        {
            Console.WriteLine("The biggest number is {0}",a);
        }
        else if (b>a && b>c && b>d && b>e) //2
        {
            Console.WriteLine("The biggest number is {0}",b);
        }
        else if (c > a && c > b && c > d && c > e) //3
        {
            Console.WriteLine("The biggest number is {0}", c);
        }
        else if (d > a && d > b && d > c && d > e) //4
        {
            Console.WriteLine("The biggest number is {0}", d);
        }
        else if (e > a && e > b && e > c && e > d) //5
        {
            Console.WriteLine("The biggest number is {0}", e);
        }
        //Added outside of given goal, for better functionality, to check if the numbers are equal.
        else if(a==b && b==c && c==d && d==e)
        {
            Console.WriteLine("The numbers are equal!");
        }
    }
}