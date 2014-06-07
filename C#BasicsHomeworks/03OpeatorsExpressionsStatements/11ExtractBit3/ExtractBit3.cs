using System;
//Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer. 
class ExtractBit3
{
    static void Main()
    {
        Console.WriteLine("This program will find the value of the bit #3 of a given unsigned integer!");
        Console.Write("Please enter a number: ");
        int a = int.Parse(Console.ReadLine());
        int thirdBit = a >> 3;
        Console.WriteLine("The value is: "+(thirdBit & 1));
    }
}