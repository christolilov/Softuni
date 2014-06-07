using System;
//Write an expression that checks for given integer if its third digit from right-to-left is 7.
class ThirdDigit
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int absoluteNumber = Math.Abs(number); //To work with negative numbers
        int number100 = absoluteNumber / 100;
        bool isSeven = (number100%10)==7;
        Console.WriteLine(isSeven ? "The third digit is seven!" : "The third digit is not seven!");
        Console.ReadLine();
    }
}