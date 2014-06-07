using System;
//Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line. 
class NumbersOneToN
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        int n = int.Parse(Console.ReadLine());
        for (int a = 1; a <= n; a++)
        {
            Console.WriteLine(a);
        }
    }
}