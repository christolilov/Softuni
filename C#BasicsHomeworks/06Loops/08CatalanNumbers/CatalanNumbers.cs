using System;
using System.Numerics;
//Write a program to calculate the nth Catalan number by given n (1 < n < 100). 
//(2n)!/((n+1)!n!)
class CatalanNumbers
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        BigInteger result = 0;
        BigInteger n2Factorial = 1;
        BigInteger n1Factorial = 1;
        BigInteger nFactorial = 1;

        if(1 < n && n < 100)
        {
            for(int i = 1;i<=2*n;i++)
            {
                if(i<=n)
                {
                    n2Factorial *= i;
                    n1Factorial *=i;
                    nFactorial *=i;
                }
                else if (i > n && i <= n + 1)
                {
                    n2Factorial *= i;
                    n1Factorial *= i;
                }
                else
                {
                    n2Factorial *= i;
                }
            }
            result = n2Factorial / (n1Factorial * nFactorial);
            Console.WriteLine(result);
        }
        else 
        {
            Console.WriteLine("Invalid input!");
        }
    }
}