using System;
//Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n not divisible by 3 and 7,
//on a single line, separated by a space. 
class NotDivisible
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        int n = int.Parse(Console.ReadLine());
        bool notDivisible = n % 3 != 0 && n % 7 != 0;
        for(int i = 1;i<=n;i++)
        {
            if(i % 3 != 0 && i % 7 != 0)
            {
                Console.Write(i);
                if(i<n)
                {
                    Console.Write(" ");
                }
            }
        }
        Console.WriteLine();
    }
}
