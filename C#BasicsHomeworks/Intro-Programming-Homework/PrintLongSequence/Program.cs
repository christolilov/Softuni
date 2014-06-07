using System;
//Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …
class PrintSequence
{
    static void Main()
    {
        for (int i = 2; i < 1002; i++)
        {
            Console.Write(" "+i * Math.Pow((-1), i));
        }
        Console.WriteLine();
    }
}