using System;
using System.Collections.Generic;
//Write a program that reads a number n and a sequence of n integers, sorts them and prints them.
class SortingNumbers
{
    static void Main()
    {
        Console.Write("How many numbers would you like to sort?: ");
        int n = int.Parse(Console.ReadLine());
        List<int> numbers = new List<int>();
        
        for(int i = 0;i<n;i++)
        {
            Console.Write("Enter number {0} : ", i + 1);
            numbers.Add(Convert.ToInt32(Console.ReadLine()));
        }
        numbers.Sort();
        foreach(int i in numbers)
        {
            Console.WriteLine(i);
        }
    }
}