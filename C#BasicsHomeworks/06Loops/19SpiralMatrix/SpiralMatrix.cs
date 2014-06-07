using System;
using System.Collections.Generic;
//Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix holding the numbers 
//from 1 to n*n in the form of square spiral. 
class SpiralMatrix
{
    static void Main()
    {
        Console.Write("Enter the dimensions of the spiral: ");
        int n = int.Parse(Console.ReadLine());
        Console.Clear();
        
        int row = 0;
        int col = -1;
        string direction = "r";
        int leftswitch = 0;
        if (n > 0 && n <= 20)
        {
            int[,] matrix = new int[n, n];
            for (int i = 1; i <= n * n; i++)
            {
                if (direction == "r")
                {
                    col++;
                    matrix[row, col] = i;

                    if ((col == (n - 1) - row) && row <= n / 2)
                    {
                        direction = "d";

                    }
                }
                else if (direction == "d")
                {
                    row++;
                    matrix[row, col] = i;

                    if (row == col)
                    {
                        direction = "l";

                    }
                }
                else if (direction == "l")
                {
                    col--;
                    matrix[row, col] = i;

                    if (col == leftswitch)
                    {
                        leftswitch++;
                        direction = "u";

                    }
                }
                else if (direction == "u")
                {
                    row--;
                    matrix[row, col] = i;

                    if (col == row - 1)
                    {
                        direction = "r";

                    }
                }
            }
            for (int p = 0; p < n; p++)
            {
                for (int f = 0; f < n; f++)
                {
                    if (n >= 10)
                    {
                        Console.Write(Convert.ToString((matrix[p, f])).PadRight(4, ' '));
                    }
                    else
                    {
                        Console.Write(Convert.ToString((matrix[p, f])).PadRight(3, ' '));
                    }
                }
                Console.WriteLine();
            }
        }
        else if(n<0 || n> 20)
        {
            Console.WriteLine("Invalid input! Valid inputs are (1 ≤ n ≤ 20) !");
        }
    }
}