using System;
//Write an expression that checks if given positive integer number n (n ≤ 100) is prime.
class PrimeNumberCheck
{
    static void Main()
    {
        Console.WriteLine("This program will check if a given number is prime!");
        Console.Write("Please enter a positive integer number n (n ≤ 100): ");
        int n =int.Parse(Console.ReadLine());
        bool isPrime = true;
        if(n==1)
        {
            isPrime = false;
            Console.WriteLine(isPrime);
        } 
        else if (n==2)
        {
            isPrime = true;
            Console.WriteLine(isPrime);
        }
        else if (n>2 && n<=100)
        {
            for (int i = 2; i < (n - 1); i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            Console.WriteLine(isPrime);
        }
        else if(n<=0 || n>100)
        {
            Console.WriteLine("You have entered an invalid number!");
        }
    }
}