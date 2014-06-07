using System;
//Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time. 
class DivideBySevenAndFive
{
    static void Main()
    {
        Console.WriteLine("This program will check if a given number can be divided by 7 and 5 in the same time without remainder!");
        Console.Write("Please enter a number: ");
        int number = int.Parse(Console.ReadLine());
        bool remainder1 = number %5 ==0;
        bool remainder2 = number %7 ==0;
        Console.WriteLine(remainder1 && remainder2 ? "The given number can be divided without remainder by 7 and 5!" : "The given number cannot be divided without remainder by 7 and 5!");
    }
}