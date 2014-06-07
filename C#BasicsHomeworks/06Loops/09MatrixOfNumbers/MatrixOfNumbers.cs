using System;
//Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix like the example below:
/*n	matrix
  4	1 2 3 4
    2 3 4 5
    3 4 5 6
    4 5 6 7
*/

class MatrixOfNumbers
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        if (1 <= n && n <= 20)
        {
            for (int i = 1; i <= n; i++)//rows
            {
                for (int p = i; p < i + n; p++)//columns
                {
                    Console.Write(p);
                    if (p < (i + n) - 1)
                    {
                        Console.Write(" ");//spaces if its not the last number in the row
                    }
                }
                Console.WriteLine();//new row
            }
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }
}