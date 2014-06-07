using System;
//Write an expression that checks if given integer is odd or even.
class OddOrEven
{
    static void Main()
    {
        Console.WriteLine("This program will calculate if a given number is odd or even!");
        Console.Write("Please enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int remainder = number % 2;
        string result = (remainder == 0 ? "even" : "odd");
        Console.WriteLine("The number you have entered is " +result+"!");
    }
}