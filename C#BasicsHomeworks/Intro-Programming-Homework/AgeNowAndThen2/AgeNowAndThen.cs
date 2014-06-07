using System;
//Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.
class AgeNowAndThen
{
    static void Main()
    {
        DateTime currentDate = DateTime.Now;
        Console.Write("Please enter your birtday: ");
        DateTime birthday = DateTime.Parse(Console.ReadLine());
        System.TimeSpan ageNow = currentDate - birthday;
        double yourAge = ageNow.TotalDays / 365.25;
        Console.WriteLine("Your age now is: "+((int)yourAge));
        Console.WriteLine("Your age after 10 years will be: " + ((int)yourAge + 10));
    }
}