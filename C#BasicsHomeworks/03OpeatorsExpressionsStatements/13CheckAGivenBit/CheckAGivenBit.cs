using System;
/*Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n has value of 1. */
class CheckAGivenBit
{
    static void Main()
    {
        Console.WriteLine("This program will determine if the value of a given bit from a given number is 1!");
        Console.Write("Please enter a number: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please enter the bit position you wish to extract: ");
        int p = int.Parse(Console.ReadLine());
        int nMask = (1 << p);
        Console.WriteLine("Is the value 1? " +((n & nMask) != 0 ? true : false));  
    }
}