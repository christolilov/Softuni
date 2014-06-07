using System;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;
//Write a method that calculates all prime numbers in given range and returns them as list of integers.
//Write a method to print a list of integers. Write a program that enters two integer numbers (each at a separate line)
//and prints all primes in their range, separated by a comma.

class PrimesInRange
{    
    //The public list
    static List<int> PrimeNumbers = new List<int>();
    //Printing method
    static void PrintPrimes()
    {
        for (int i = 0; i < PrimeNumbers.Count; i++)
        {
            Console.Write(PrimeNumbers[i]);
            if (i < PrimeNumbers.Count - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }
    //Method for finding primes
    static void FindPrimes(int startNum,int endNum)
    {
        for (int i = startNum; i <= endNum;i++)
        {
            bool isPrime = true;
            for(int p = 2;p<i;p++)
            {
                if(i%p==0)
                {
                    isPrime = false;
                }
            }
            if(isPrime)
            {
                if(i>1)
                {
                    PrimeNumbers.Add(i);
                }
                
            }
        }
            
    }
    //Input and method calls
    static void Main()
    {
        int startNum = int.Parse(Console.ReadLine());
        int endNum = int.Parse(Console.ReadLine());
        FindPrimes(startNum, endNum);
        PrintPrimes();
    }
}