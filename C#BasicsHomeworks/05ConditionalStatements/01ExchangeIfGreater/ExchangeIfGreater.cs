using System;
//Write an if-statement that takes two integer variables a and b and exchanges their values if the first one is greater than the second one.
//As a result print the values a and b, separated by a space.
class ExchangeIfGreater
{
    static void Main()
    {
        Console.WriteLine("This program will exchange the values of a and b if a>b!");
        Console.Write("Enter a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        int b = int.Parse(Console.ReadLine());
        int c = a;
        if(a>b)
        {
            a = b;
            b = c;            
            Console.WriteLine("a = "+a);
            Console.WriteLine("b = "+b);
        }
        else
        {
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
        }
    }
}
