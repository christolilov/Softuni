using System;
using System.Linq;
/*Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average
 * of all numbers (displayed with 2 digits after the decimal point). The input starts by the number n (alone in a line) followed by n lines, 
 * each holding an integer number.*/
class MinMaxSumAndAverage
{
    static void Main()
    {
        //Za da napravq programata da raboti s vsqkakuv broi chisla, prouchih kak se polzvat masivi i saotvetno kak se pravqt matematicheski operacii
        //s masivi, izpolzvaiki System.Linq
        Console.Write("Enter the amount of numbers: ");
        int n = int.Parse(Console.ReadLine());
        double[] numbers = new double[n];
        for(int i =0;i<n;i++)
        {
            Console.Write("Enter number {0}: ",i+1);
            numbers[i] = double.Parse(Console.ReadLine()); 
        }
        double average = numbers.Average();
        Console.WriteLine("min = {0}", numbers.Min());
        Console.WriteLine("max = {0}", numbers.Max());
        Console.WriteLine("sum = {0}", numbers.Sum());
        Console.WriteLine("avg = {0:0.00}",average);
    }
}