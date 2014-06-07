using System;
using System.Globalization;
//Write a program that enters two dates in format dd.MM.yyyy and returns the number of days between them.
class DiffereceBetweenDates
{
    static void Main()
    {
        start:
        try
        {
            Console.WriteLine("The correct format for dates is dd.MM.yyyy");
            Console.Write("Enter first date: ");
            DateTime dateOne = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
            Console.Write("Enter second date: ");
            DateTime dateTwo = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
            TimeSpan difference = dateTwo - dateOne;
            Console.WriteLine(difference.TotalDays);
        }
        catch(FormatException)//Checks for wrong date format
        {
            Console.WriteLine("Wrong input!");
            Console.WriteLine("Try again!");
            goto start;//Returns to start of the program
        }
    }
}