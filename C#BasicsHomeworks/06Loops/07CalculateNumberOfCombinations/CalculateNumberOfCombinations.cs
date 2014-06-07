using System;
using System.Numerics;
//Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). 
class CalculateCombinations
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter k: ");
        int k = int.Parse(Console.ReadLine());
        BigInteger nFactorial = 1;
        BigInteger kFactorial = 1;
        BigInteger nkFactorial = 1;
        BigInteger result = 0;
        if (1 < k && k < n && n < 100)
        {
            for(int i = 1;i<=n;i++)
            {
                if(i<=k)
                {
                    kFactorial *= i;
                }
                nFactorial *= i;
            }
            for(int p = 1;p<=(n-k);p++)
            {
                nkFactorial *= p;
            }
            result = nFactorial / (kFactorial * nkFactorial);
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }

    }
}