using System;
//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.
class SumOfFiveNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter five numbers, separated by a space:");
        string[] numbers = Console.ReadLine().Split();
        int a = int.Parse(numbers[0]);
        int b = int.Parse(numbers[1]);
        int c = int.Parse(numbers[2]);
        int d = int.Parse(numbers[3]);
        int e = int.Parse(numbers[4]);
        int sum = a+b+c+d+e;
        Console.WriteLine("The sum is: "+sum);
    }
}
