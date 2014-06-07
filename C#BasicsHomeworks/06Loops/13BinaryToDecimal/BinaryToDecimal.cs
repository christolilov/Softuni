using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Using loops write a program that converts a binary integer number to its decimal form. The input is entered as string. 
//The output should be a variable of type long. Do not use the built-in .NET functionality.
class BinaryToDecimal
{
    static void Main()
    {
        Console.WriteLine("Enter a binary number: ");
        string binary = Console.ReadLine();
        int lenght = binary.Length;
        List<Char> numbers = new List<Char>();
        double counter = 0;
        double result = 0;
        for(int i = 0;i<lenght;i++)
        {
            numbers.Add(binary.ElementAt(i));
        }
        numbers.Reverse();
        foreach (var number in numbers)
        {
            if(number=='1')
            {
                result += Math.Pow(2, counter);
            }
            counter++;
        }
        long resultToLong = (long)result;
        Console.WriteLine("The decimal representation of the entered binary number is: ");
        Console.WriteLine(resultToLong);
    }
}