using System;
using System.Numerics;
//Define a method Fib(n) that calculates the nth Fibonacci number. 
class FibonacciNumbers
{    
    static void Main()
    {
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(Fib(n));
    }



    static BigInteger Fib(int n)
    {
       BigInteger a = 0;
       BigInteger b = 1;
       BigInteger c = 0;
        if(n == 0)
        {
            c = 1;
        }
        else 
        {
            for(BigInteger i = 0;i<n;i++)
            {
                c = a + b;
                a = b;
                b = c;
            } 
        }
        return c;
    }
}