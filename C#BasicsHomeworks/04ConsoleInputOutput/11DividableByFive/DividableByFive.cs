using System;
//Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0.
class DividableByFive
{
    static void Main()
    {
        Console.WriteLine("This program will determine the numbers, dividable by 5 in a given range!");
        Console.Write("Please enter the start of the range: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Please enter the end of the range: ");
        int b = int.Parse(Console.ReadLine());
        int numberCount = 0;
        if (a < b)
        {
            for (int counter = a; counter <= b; counter++)
            {
                if (counter % 5 == 0)
                {
                    numberCount++;
                    Console.Write(" {0}", counter);
                }
            }
        Console.WriteLine();
        Console.WriteLine("There are {0} numbers between {1} and {2} dividable by 5!",numberCount,a,b);
        }
        else if (a>b)
        {
            Console.WriteLine("The start of the range cannot be greater than the end of the range!");
        }
        else if (a==b)
        {
            Console.WriteLine("The start of the range cannot be equal with the end of the range!");
        }
    } 
}