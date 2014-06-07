using System;
//Write a program that calculates n! / k! for given n and k (1 < k < n < 100). Use only one loop.
class DivideFactorials
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter k: ");
        int k = int.Parse(Console.ReadLine());
        int kFactorial = 1;
        int nFactorial = 1;
        double result = 0;
        if (1 < k && k < n && n < 100)
        {
            for (int i = 1; i <= n; i++)
            {
                if (i <= k)
                {
                    kFactorial *= i;
                }
                nFactorial *= i;
            }
            result = nFactorial / kFactorial;
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
    }
}
