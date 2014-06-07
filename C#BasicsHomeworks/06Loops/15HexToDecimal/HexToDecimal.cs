using System;
//Using loops write a program that converts a hexadecimal integer number to its decimal form. 
//The input is entered as string. The output should be a variable of type long. Do not use the built-in .NET functionality.
class HexToDecimal
{
    static void Main()
    {
        string hex = Console.ReadLine();
        int lenght = hex.Length;
        int s = 0;
        double result = 0;
        int[] input = new int[lenght];
        foreach(char ch in hex)
        {
            if(ch=='A')
            {
                input[s] = 10;
                s++;
            }
            else if (ch=='B')
            {
                input[s] = 11;
                s++;
            }
            else if(ch=='C')
            {
                input[s] = 12;
                s++;
            }
            else if (ch == 'D')
            {
                input[s] = 13;
                s++;
            }
            else if (ch == 'E')
            {
                input[s] = 14;
                s++;
            }
            else if (ch == 'F')
            {
                input[s] = 15;
                s++;
            }
            else 
            {
                input[s] = Convert.ToInt32(Convert.ToString(ch));
                s++;
            }
        }
        s = 0;
        foreach(int num in input)
        {
            result += num * (Math.Pow(16, (lenght - (1+s))));
            s++;
        }
        Console.WriteLine(result);
    }
}