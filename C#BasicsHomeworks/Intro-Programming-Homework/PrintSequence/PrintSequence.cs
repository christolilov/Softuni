using System;
//Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...
class PrintSequence
{
    static void Main()
    {
        for (int i = 2; i < 12; i++)
        {
            Console.WriteLine(i * Math.Pow((-1), i));
        }
    }
}