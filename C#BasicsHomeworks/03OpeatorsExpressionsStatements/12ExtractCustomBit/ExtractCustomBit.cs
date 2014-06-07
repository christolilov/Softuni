using System;
//Write an expression that extracts from given integer n the value of given bit at index p.
class ExtractCustomBit
{
    static void Main()
    {
        Console.WriteLine("This program will extract the value of a given bit from a given number!");
        Console.Write("Please enter a number: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please enter the bit position you wish to extract: ");
        int p = int.Parse(Console.ReadLine());
        int nShifted = n >> p;
        Console.WriteLine("The given bit value is: "+(nShifted & 1));
    }
}