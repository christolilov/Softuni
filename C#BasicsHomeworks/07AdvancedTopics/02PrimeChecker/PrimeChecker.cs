using System;
using System.Numerics;
//Write a Boolean method IsPrime(n) that check whether a given integer number n is prime. 
class PrimeChecker
{
    static void Main()
    {
        Console.Write("Enter number: ");
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        Console.WriteLine(IsPrime(n));

    }
    static bool IsPrime(BigInteger n)
    {
        bool isPrime = true;
        if(n==0||n==1)
        {
            return false;
        }
        else if(n==2||n==3)
        {
            return true;
        }
        else if(n<100&&n>3)
        {
            for(int s=2;s<n;s++)
            {
                if (n % s == 0)
                    isPrime = false;
            }
            return isPrime;
        }
        else
        {
            for (BigInteger i = 3; (i * i) <= n; i+=2)
            {
                if (n%i==0)
                {
                    isPrime = false;
                    break;
                }
            }
            return isPrime;
        }
    }
}