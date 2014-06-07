using System;
//Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/xn. 
//Use only one loop. Print the result with 5 digits after the decimal point.
class CalculateFactorialFormula
{
    static void Main()
    {
        Console.Write("Enter n :");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter x :");
        int x = int.Parse(Console.ReadLine());
        double result = 1;
        double nFactorial = 1;
        double xn = 1;
        for(int i = 1;i<=n;i++)
        {
            nFactorial *= i;
            xn *= x;
            result += nFactorial / xn;
        }
        Console.WriteLine("{0:F5}",result);
    }
}
