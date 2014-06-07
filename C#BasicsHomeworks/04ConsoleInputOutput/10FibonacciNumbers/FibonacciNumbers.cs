using System;
//Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence.
class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("Please enter your number: ");
        int n = int.Parse(Console.ReadLine());
        int a = 0;
        int b = 1;
        if(n==0)
        {
            Console.WriteLine("You must enter a number larger than 0!");
        }
        else if(n==1)
        {
            Console.WriteLine("0");
        }
        else if(n==2)
        {
            Console.WriteLine("0 1");
        }
        else
        {
            Console.Write("{0} {1}",a,b);
            for (int i = 0; i + 2 < n; i++)
            {
                int c = a + b;

                Console.Write(" {0}", c);
                a = b;
                b = c;
            }
            Console.WriteLine();
        }
    }
}