using System;
//Write a program that calculates the greatest common divisor (GCD) of given two integers a and b. 
//Use the Euclidean algorithm (find it in Internet). 
class CalculateGCD
{
    static void Main()
    {
    int a = Math.Abs(int.Parse(Console.ReadLine()));
    int b = Math.Abs(int.Parse(Console.ReadLine()));
        while (a != 0 && b != 0)
        {
            if (a > b)
            {
                a %= b;
            }
            else
            {
                b %= a;
            }
        }

        if (a == 0)
        {
            Console.WriteLine("GCD is: " + b);
        }   
        else
        {
            Console.WriteLine("GCD is: "+a);
        }
    }
}