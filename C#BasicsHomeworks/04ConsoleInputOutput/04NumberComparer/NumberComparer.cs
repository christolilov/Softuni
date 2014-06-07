using System;
//Write a program that gets two numbers from the console and prints the greater of them. Try to implement this without if statements
class NumberComparer
{
    static void Main()
    {
        Console.WriteLine("This program will determine the greater of two given numbers!");
        Console.Write("Please enter the first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Please enter the second number: ");
        double b = double.Parse(Console.ReadLine());
        if (a != b) //If statement is used just to see if the two numbers are equal.Not for the comparison itself.Just4Fun
        {
            Console.WriteLine("The greater number is: " + Math.Max(a, b));
        }
        else
        {
            Console.WriteLine("The two numbers are equal!");
        }
    }
}